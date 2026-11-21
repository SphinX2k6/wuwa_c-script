using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E18 RID: 28184
	public struct IFailurePoseInteract : IFlatbufferObject
	{
		// Token: 0x1700CE94 RID: 52884
		// (get) Token: 0x06030A9C RID: 199324 RVA: 0x0069B0C7 File Offset: 0x006992C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A9D RID: 199325 RVA: 0x0069B0D4 File Offset: 0x006992D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A9E RID: 199326 RVA: 0x0069B0DC File Offset: 0x006992DC
		public static IFailurePoseInteract GetRootAsIFailurePoseInteract(ByteBuffer _bb)
		{
			return IFailurePoseInteract.GetRootAsIFailurePoseInteract(_bb, default(IFailurePoseInteract));
		}

		// Token: 0x06030A9F RID: 199327 RVA: 0x0069B0F8 File Offset: 0x006992F8
		public static IFailurePoseInteract GetRootAsIFailurePoseInteract(ByteBuffer _bb, IFailurePoseInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AA0 RID: 199328 RVA: 0x0069B115 File Offset: 0x00699315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AA1 RID: 199329 RVA: 0x0069B124 File Offset: 0x00699324
		public IFailurePoseInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE95 RID: 52885
		// (get) Token: 0x06030AA2 RID: 199330 RVA: 0x0069B134 File Offset: 0x00699334
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE96 RID: 52886
		// (get) Token: 0x06030AA3 RID: 199331 RVA: 0x0069B170 File Offset: 0x00699370
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06030AA4 RID: 199332 RVA: 0x0069B1CD File Offset: 0x006993CD
		public static Offset<IFailurePoseInteract> CreateIFailurePoseInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IFailurePoseInteract.AddRot(builder, RotOffset);
			IFailurePoseInteract.AddType(builder, Type);
			return IFailurePoseInteract.EndIFailurePoseInteract(builder);
		}

		// Token: 0x06030AA5 RID: 199333 RVA: 0x0069B1EA File Offset: 0x006993EA
		public static void StartIFailurePoseInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030AA6 RID: 199334 RVA: 0x0069B1F3 File Offset: 0x006993F3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030AA7 RID: 199335 RVA: 0x0069B1FE File Offset: 0x006993FE
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x06030AA8 RID: 199336 RVA: 0x0069B20E File Offset: 0x0069940E
		public static Offset<IFailurePoseInteract> EndIFailurePoseInteract(FlatBufferBuilder builder)
		{
			return new Offset<IFailurePoseInteract>(builder.EndTable());
		}

		// Token: 0x06030AA9 RID: 199337 RVA: 0x0069B21C File Offset: 0x0069941C
		public IFailurePoseInteractT UnPack()
		{
			IFailurePoseInteractT failurePoseInteractT = new IFailurePoseInteractT();
			this.UnPackTo(failurePoseInteractT);
			return failurePoseInteractT;
		}

		// Token: 0x06030AAA RID: 199338 RVA: 0x0069B238 File Offset: 0x00699438
		public void UnPackTo(IFailurePoseInteractT _o)
		{
			_o.Type = this.Type;
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06030AAB RID: 199339 RVA: 0x0069B280 File Offset: 0x00699480
		public static Offset<IFailurePoseInteract> Pack(FlatBufferBuilder builder, IFailurePoseInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailurePoseInteract>);
			}
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IFailurePoseInteract.CreateIFailurePoseInteract(builder, _o.Type, rotOffset);
		}

		// Token: 0x04011CD9 RID: 72921
		private Table __p;
	}
}
