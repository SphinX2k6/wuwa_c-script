using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427A RID: 17018
	public struct IVisionSystemQuestSetActivated : IFlatbufferObject
	{
		// Token: 0x170078C8 RID: 30920
		// (get) Token: 0x06019306 RID: 103174 RVA: 0x0039E8C5 File Offset: 0x0039CAC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019307 RID: 103175 RVA: 0x0039E8D2 File Offset: 0x0039CAD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019308 RID: 103176 RVA: 0x0039E8DC File Offset: 0x0039CADC
		public static IVisionSystemQuestSetActivated GetRootAsIVisionSystemQuestSetActivated(ByteBuffer _bb)
		{
			return IVisionSystemQuestSetActivated.GetRootAsIVisionSystemQuestSetActivated(_bb, default(IVisionSystemQuestSetActivated));
		}

		// Token: 0x06019309 RID: 103177 RVA: 0x0039E8F8 File Offset: 0x0039CAF8
		public static IVisionSystemQuestSetActivated GetRootAsIVisionSystemQuestSetActivated(ByteBuffer _bb, IVisionSystemQuestSetActivated obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601930A RID: 103178 RVA: 0x0039E915 File Offset: 0x0039CB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601930B RID: 103179 RVA: 0x0039E924 File Offset: 0x0039CB24
		public IVisionSystemQuestSetActivated __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078C9 RID: 30921
		// (get) Token: 0x0601930C RID: 103180 RVA: 0x0039E934 File Offset: 0x0039CB34
		public EVisionSystemQuestType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisionSystemQuestType.HasVisionGetTargetLevel;
				}
				return (EVisionSystemQuestType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078CA RID: 30922
		// (get) Token: 0x0601930D RID: 103181 RVA: 0x0039E970 File Offset: 0x0039CB70
		public EVisionSetType SetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVisionSetType.None;
				}
				return (EVisionSetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601930E RID: 103182 RVA: 0x0039E9AC File Offset: 0x0039CBAC
		public static Offset<IVisionSystemQuestSetActivated> CreateIVisionSystemQuestSetActivated(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel, EVisionSetType SetType = EVisionSetType.None)
		{
			builder.StartTable(2);
			IVisionSystemQuestSetActivated.AddSetType(builder, SetType);
			IVisionSystemQuestSetActivated.AddType(builder, Type);
			return IVisionSystemQuestSetActivated.EndIVisionSystemQuestSetActivated(builder);
		}

		// Token: 0x0601930F RID: 103183 RVA: 0x0039E9C9 File Offset: 0x0039CBC9
		public static void StartIVisionSystemQuestSetActivated(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019310 RID: 103184 RVA: 0x0039E9D2 File Offset: 0x0039CBD2
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019311 RID: 103185 RVA: 0x0039E9DD File Offset: 0x0039CBDD
		public static void AddSetType(FlatBufferBuilder builder, EVisionSetType setType)
		{
			builder.AddByte(1, (byte)setType, 0);
		}

		// Token: 0x06019312 RID: 103186 RVA: 0x0039E9E8 File Offset: 0x0039CBE8
		public static Offset<IVisionSystemQuestSetActivated> EndIVisionSystemQuestSetActivated(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestSetActivated>(builder.EndTable());
		}

		// Token: 0x06019313 RID: 103187 RVA: 0x0039E9F8 File Offset: 0x0039CBF8
		public IVisionSystemQuestSetActivatedT UnPack()
		{
			IVisionSystemQuestSetActivatedT visionSystemQuestSetActivatedT = new IVisionSystemQuestSetActivatedT();
			this.UnPackTo(visionSystemQuestSetActivatedT);
			return visionSystemQuestSetActivatedT;
		}

		// Token: 0x06019314 RID: 103188 RVA: 0x0039EA13 File Offset: 0x0039CC13
		public void UnPackTo(IVisionSystemQuestSetActivatedT _o)
		{
			_o.Type = this.Type;
			_o.SetType = this.SetType;
		}

		// Token: 0x06019315 RID: 103189 RVA: 0x0039EA30 File Offset: 0x0039CC30
		public static Offset<IVisionSystemQuestSetActivated> Pack(FlatBufferBuilder builder, IVisionSystemQuestSetActivatedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestSetActivated>);
			}
			return IVisionSystemQuestSetActivated.CreateIVisionSystemQuestSetActivated(builder, _o.Type, _o.SetType);
		}

		// Token: 0x0400BF10 RID: 48912
		private Table __p;
	}
}
