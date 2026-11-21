using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F5 RID: 17909
	public struct ITakePhoto2TargetPlayMontageCondition : IFlatbufferObject
	{
		// Token: 0x17007D4E RID: 32078
		// (get) Token: 0x0601A2D5 RID: 107221 RVA: 0x003BA884 File Offset: 0x003B8A84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x003BA891 File Offset: 0x003B8A91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x003BA898 File Offset: 0x003B8A98
		public static ITakePhoto2TargetPlayMontageCondition GetRootAsITakePhoto2TargetPlayMontageCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPlayMontageCondition.GetRootAsITakePhoto2TargetPlayMontageCondition(_bb, default(ITakePhoto2TargetPlayMontageCondition));
		}

		// Token: 0x0601A2D8 RID: 107224 RVA: 0x003BA8B4 File Offset: 0x003B8AB4
		public static ITakePhoto2TargetPlayMontageCondition GetRootAsITakePhoto2TargetPlayMontageCondition(ByteBuffer _bb, ITakePhoto2TargetPlayMontageCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2D9 RID: 107225 RVA: 0x003BA8D1 File Offset: 0x003B8AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2DA RID: 107226 RVA: 0x003BA8E0 File Offset: 0x003B8AE0
		public ITakePhoto2TargetPlayMontageCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D4F RID: 32079
		// (get) Token: 0x0601A2DB RID: 107227 RVA: 0x003BA8F0 File Offset: 0x003B8AF0
		public string MontagePath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A2DC RID: 107228 RVA: 0x003BA927 File Offset: 0x003B8B27
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A2DD RID: 107229 RVA: 0x003BA936 File Offset: 0x003B8B36
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601A2DE RID: 107230 RVA: 0x003BA944 File Offset: 0x003B8B44
		public static Offset<ITakePhoto2TargetPlayMontageCondition> CreateITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder, StringOffset MontagePathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetPlayMontageCondition.AddMontagePath(builder, MontagePathOffset);
			return ITakePhoto2TargetPlayMontageCondition.EndITakePhoto2TargetPlayMontageCondition(builder);
		}

		// Token: 0x0601A2DF RID: 107231 RVA: 0x003BA95A File Offset: 0x003B8B5A
		public static void StartITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A2E0 RID: 107232 RVA: 0x003BA963 File Offset: 0x003B8B63
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(0, montagePathOffset.Value, 0);
		}

		// Token: 0x0601A2E1 RID: 107233 RVA: 0x003BA973 File Offset: 0x003B8B73
		public static Offset<ITakePhoto2TargetPlayMontageCondition> EndITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPlayMontageCondition>(builder.EndTable());
		}

		// Token: 0x0601A2E2 RID: 107234 RVA: 0x003BA980 File Offset: 0x003B8B80
		public ITakePhoto2TargetPlayMontageConditionT UnPack()
		{
			ITakePhoto2TargetPlayMontageConditionT takePhoto2TargetPlayMontageConditionT = new ITakePhoto2TargetPlayMontageConditionT();
			this.UnPackTo(takePhoto2TargetPlayMontageConditionT);
			return takePhoto2TargetPlayMontageConditionT;
		}

		// Token: 0x0601A2E3 RID: 107235 RVA: 0x003BA99B File Offset: 0x003B8B9B
		public void UnPackTo(ITakePhoto2TargetPlayMontageConditionT _o)
		{
			_o.MontagePath = this.MontagePath;
		}

		// Token: 0x0601A2E4 RID: 107236 RVA: 0x003BA9AC File Offset: 0x003B8BAC
		public static Offset<ITakePhoto2TargetPlayMontageCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetPlayMontageConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetPlayMontageCondition>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			return ITakePhoto2TargetPlayMontageCondition.CreateITakePhoto2TargetPlayMontageCondition(builder, montagePathOffset);
		}

		// Token: 0x0400C7DF RID: 51167
		private Table __p;
	}
}
