using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004616 RID: 17942
	public struct ITetrisPlayModeBase : IFlatbufferObject
	{
		// Token: 0x17007D81 RID: 32129
		// (get) Token: 0x0601A3DC RID: 107484 RVA: 0x003BC96B File Offset: 0x003BAB6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3DD RID: 107485 RVA: 0x003BC978 File Offset: 0x003BAB78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3DE RID: 107486 RVA: 0x003BC980 File Offset: 0x003BAB80
		public static ITetrisPlayModeBase GetRootAsITetrisPlayModeBase(ByteBuffer _bb)
		{
			return ITetrisPlayModeBase.GetRootAsITetrisPlayModeBase(_bb, default(ITetrisPlayModeBase));
		}

		// Token: 0x0601A3DF RID: 107487 RVA: 0x003BC99C File Offset: 0x003BAB9C
		public static ITetrisPlayModeBase GetRootAsITetrisPlayModeBase(ByteBuffer _bb, ITetrisPlayModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3E0 RID: 107488 RVA: 0x003BC9B9 File Offset: 0x003BABB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3E1 RID: 107489 RVA: 0x003BC9C8 File Offset: 0x003BABC8
		public ITetrisPlayModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D82 RID: 32130
		// (get) Token: 0x0601A3E2 RID: 107490 RVA: 0x003BC9D8 File Offset: 0x003BABD8
		public ETetrisPlayMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETetrisPlayMode.Normal;
				}
				return (ETetrisPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A3E3 RID: 107491 RVA: 0x003BCA14 File Offset: 0x003BAC14
		public static Offset<ITetrisPlayModeBase> CreateITetrisPlayModeBase(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal)
		{
			builder.StartTable(1);
			ITetrisPlayModeBase.AddType(builder, Type);
			return ITetrisPlayModeBase.EndITetrisPlayModeBase(builder);
		}

		// Token: 0x0601A3E4 RID: 107492 RVA: 0x003BCA2A File Offset: 0x003BAC2A
		public static void StartITetrisPlayModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A3E5 RID: 107493 RVA: 0x003BCA33 File Offset: 0x003BAC33
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A3E6 RID: 107494 RVA: 0x003BCA3E File Offset: 0x003BAC3E
		public static Offset<ITetrisPlayModeBase> EndITetrisPlayModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeBase>(builder.EndTable());
		}

		// Token: 0x0601A3E7 RID: 107495 RVA: 0x003BCA4C File Offset: 0x003BAC4C
		public ITetrisPlayModeBaseT UnPack()
		{
			ITetrisPlayModeBaseT tetrisPlayModeBaseT = new ITetrisPlayModeBaseT();
			this.UnPackTo(tetrisPlayModeBaseT);
			return tetrisPlayModeBaseT;
		}

		// Token: 0x0601A3E8 RID: 107496 RVA: 0x003BCA67 File Offset: 0x003BAC67
		public void UnPackTo(ITetrisPlayModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A3E9 RID: 107497 RVA: 0x003BCA78 File Offset: 0x003BAC78
		public static Offset<ITetrisPlayModeBase> Pack(FlatBufferBuilder builder, ITetrisPlayModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeBase>);
			}
			return ITetrisPlayModeBase.CreateITetrisPlayModeBase(builder, _o.Type);
		}

		// Token: 0x0400C80B RID: 51211
		private Table __p;
	}
}
