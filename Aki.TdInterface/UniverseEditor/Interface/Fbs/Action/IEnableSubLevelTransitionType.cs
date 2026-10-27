using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200668A RID: 26250
	public struct IEnableSubLevelTransitionType : IFlatbufferObject
	{
		// Token: 0x1700C315 RID: 49941
		// (get) Token: 0x0602D9F3 RID: 186867 RVA: 0x0063EACD File Offset: 0x0063CCCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9F4 RID: 186868 RVA: 0x0063EADA File Offset: 0x0063CCDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9F5 RID: 186869 RVA: 0x0063EAE4 File Offset: 0x0063CCE4
		public static IEnableSubLevelTransitionType GetRootAsIEnableSubLevelTransitionType(ByteBuffer _bb)
		{
			return IEnableSubLevelTransitionType.GetRootAsIEnableSubLevelTransitionType(_bb, default(IEnableSubLevelTransitionType));
		}

		// Token: 0x0602D9F6 RID: 186870 RVA: 0x0063EB00 File Offset: 0x0063CD00
		public static IEnableSubLevelTransitionType GetRootAsIEnableSubLevelTransitionType(ByteBuffer _bb, IEnableSubLevelTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9F7 RID: 186871 RVA: 0x0063EB1D File Offset: 0x0063CD1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9F8 RID: 186872 RVA: 0x0063EB2C File Offset: 0x0063CD2C
		public IEnableSubLevelTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C316 RID: 49942
		// (get) Token: 0x0602D9F9 RID: 186873 RVA: 0x0063EB3C File Offset: 0x0063CD3C
		public EEnableSubLevelTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return (EEnableSubLevelTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D9FA RID: 186874 RVA: 0x0063EB78 File Offset: 0x0063CD78
		public static Offset<IEnableSubLevelTransitionType> CreateIEnableSubLevelTransitionType(FlatBufferBuilder builder, EEnableSubLevelTransitionType Type = EEnableSubLevelTransitionType.SceneCapture)
		{
			builder.StartTable(1);
			IEnableSubLevelTransitionType.AddType(builder, Type);
			return IEnableSubLevelTransitionType.EndIEnableSubLevelTransitionType(builder);
		}

		// Token: 0x0602D9FB RID: 186875 RVA: 0x0063EB8E File Offset: 0x0063CD8E
		public static void StartIEnableSubLevelTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D9FC RID: 186876 RVA: 0x0063EB97 File Offset: 0x0063CD97
		public static void AddType(FlatBufferBuilder builder, EEnableSubLevelTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D9FD RID: 186877 RVA: 0x0063EBA2 File Offset: 0x0063CDA2
		public static Offset<IEnableSubLevelTransitionType> EndIEnableSubLevelTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSubLevelTransitionType>(builder.EndTable());
		}

		// Token: 0x0602D9FE RID: 186878 RVA: 0x0063EBB0 File Offset: 0x0063CDB0
		public IEnableSubLevelTransitionTypeT UnPack()
		{
			IEnableSubLevelTransitionTypeT enableSubLevelTransitionTypeT = new IEnableSubLevelTransitionTypeT();
			this.UnPackTo(enableSubLevelTransitionTypeT);
			return enableSubLevelTransitionTypeT;
		}

		// Token: 0x0602D9FF RID: 186879 RVA: 0x0063EBCB File Offset: 0x0063CDCB
		public void UnPackTo(IEnableSubLevelTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DA00 RID: 186880 RVA: 0x0063EBDC File Offset: 0x0063CDDC
		public static Offset<IEnableSubLevelTransitionType> Pack(FlatBufferBuilder builder, IEnableSubLevelTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSubLevelTransitionType>);
			}
			return IEnableSubLevelTransitionType.CreateIEnableSubLevelTransitionType(builder, _o.Type);
		}

		// Token: 0x04010D3F RID: 68927
		private Table __p;
	}
}
