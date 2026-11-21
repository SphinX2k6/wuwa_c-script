using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AA RID: 22698
	public struct IGravityFlipConfig : IFlatbufferObject
	{
		// Token: 0x1700A483 RID: 42115
		// (get) Token: 0x06024D2C RID: 150828 RVA: 0x0050E6B7 File Offset: 0x0050C8B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D2D RID: 150829 RVA: 0x0050E6C4 File Offset: 0x0050C8C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D2E RID: 150830 RVA: 0x0050E6CC File Offset: 0x0050C8CC
		public static IGravityFlipConfig GetRootAsIGravityFlipConfig(ByteBuffer _bb)
		{
			return IGravityFlipConfig.GetRootAsIGravityFlipConfig(_bb, default(IGravityFlipConfig));
		}

		// Token: 0x06024D2F RID: 150831 RVA: 0x0050E6E8 File Offset: 0x0050C8E8
		public static IGravityFlipConfig GetRootAsIGravityFlipConfig(ByteBuffer _bb, IGravityFlipConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D30 RID: 150832 RVA: 0x0050E705 File Offset: 0x0050C905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D31 RID: 150833 RVA: 0x0050E714 File Offset: 0x0050C914
		public IGravityFlipConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A484 RID: 42116
		// (get) Token: 0x06024D32 RID: 150834 RVA: 0x0050E724 File Offset: 0x0050C924
		public EGravityFlipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityFlipType.None;
				}
				return (EGravityFlipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A485 RID: 42117
		// (get) Token: 0x06024D33 RID: 150835 RVA: 0x0050E760 File Offset: 0x0050C960
		public int LocationEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024D34 RID: 150836 RVA: 0x0050E79C File Offset: 0x0050C99C
		public static Offset<IGravityFlipConfig> CreateIGravityFlipConfig(FlatBufferBuilder builder, EGravityFlipType Type = EGravityFlipType.None, int LocationEntityId = 0)
		{
			builder.StartTable(2);
			IGravityFlipConfig.AddLocationEntityId(builder, LocationEntityId);
			IGravityFlipConfig.AddType(builder, Type);
			return IGravityFlipConfig.EndIGravityFlipConfig(builder);
		}

		// Token: 0x06024D35 RID: 150837 RVA: 0x0050E7B9 File Offset: 0x0050C9B9
		public static void StartIGravityFlipConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024D36 RID: 150838 RVA: 0x0050E7C2 File Offset: 0x0050C9C2
		public static void AddType(FlatBufferBuilder builder, EGravityFlipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024D37 RID: 150839 RVA: 0x0050E7CD File Offset: 0x0050C9CD
		public static void AddLocationEntityId(FlatBufferBuilder builder, int locationEntityId)
		{
			builder.AddInt(1, locationEntityId, 0);
		}

		// Token: 0x06024D38 RID: 150840 RVA: 0x0050E7D8 File Offset: 0x0050C9D8
		public static Offset<IGravityFlipConfig> EndIGravityFlipConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipConfig>(builder.EndTable());
		}

		// Token: 0x06024D39 RID: 150841 RVA: 0x0050E7E8 File Offset: 0x0050C9E8
		public IGravityFlipConfigT UnPack()
		{
			IGravityFlipConfigT gravityFlipConfigT = new IGravityFlipConfigT();
			this.UnPackTo(gravityFlipConfigT);
			return gravityFlipConfigT;
		}

		// Token: 0x06024D3A RID: 150842 RVA: 0x0050E803 File Offset: 0x0050CA03
		public void UnPackTo(IGravityFlipConfigT _o)
		{
			_o.Type = this.Type;
			_o.LocationEntityId = this.LocationEntityId;
		}

		// Token: 0x06024D3B RID: 150843 RVA: 0x0050E820 File Offset: 0x0050CA20
		public static Offset<IGravityFlipConfig> Pack(FlatBufferBuilder builder, IGravityFlipConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipConfig>);
			}
			return IGravityFlipConfig.CreateIGravityFlipConfig(builder, _o.Type, _o.LocationEntityId);
		}

		// Token: 0x0400F110 RID: 61712
		private Table __p;
	}
}
