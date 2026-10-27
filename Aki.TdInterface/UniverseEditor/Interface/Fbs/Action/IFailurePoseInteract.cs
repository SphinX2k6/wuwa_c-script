using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006798 RID: 26520
	public struct IFailurePoseInteract : IFlatbufferObject
	{
		// Token: 0x1700C4DE RID: 50398
		// (get) Token: 0x0602E256 RID: 189014 RVA: 0x0064D983 File Offset: 0x0064BB83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E257 RID: 189015 RVA: 0x0064D990 File Offset: 0x0064BB90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E258 RID: 189016 RVA: 0x0064D998 File Offset: 0x0064BB98
		public static IFailurePoseInteract GetRootAsIFailurePoseInteract(ByteBuffer _bb)
		{
			return IFailurePoseInteract.GetRootAsIFailurePoseInteract(_bb, default(IFailurePoseInteract));
		}

		// Token: 0x0602E259 RID: 189017 RVA: 0x0064D9B4 File Offset: 0x0064BBB4
		public static IFailurePoseInteract GetRootAsIFailurePoseInteract(ByteBuffer _bb, IFailurePoseInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E25A RID: 189018 RVA: 0x0064D9D1 File Offset: 0x0064BBD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E25B RID: 189019 RVA: 0x0064D9E0 File Offset: 0x0064BBE0
		public IFailurePoseInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4DF RID: 50399
		// (get) Token: 0x0602E25C RID: 189020 RVA: 0x0064D9F0 File Offset: 0x0064BBF0
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

		// Token: 0x1700C4E0 RID: 50400
		// (get) Token: 0x0602E25D RID: 189021 RVA: 0x0064DA2C File Offset: 0x0064BC2C
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

		// Token: 0x0602E25E RID: 189022 RVA: 0x0064DA89 File Offset: 0x0064BC89
		public static Offset<IFailurePoseInteract> CreateIFailurePoseInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IFailurePoseInteract.AddRot(builder, RotOffset);
			IFailurePoseInteract.AddType(builder, Type);
			return IFailurePoseInteract.EndIFailurePoseInteract(builder);
		}

		// Token: 0x0602E25F RID: 189023 RVA: 0x0064DAA6 File Offset: 0x0064BCA6
		public static void StartIFailurePoseInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E260 RID: 189024 RVA: 0x0064DAAF File Offset: 0x0064BCAF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E261 RID: 189025 RVA: 0x0064DABA File Offset: 0x0064BCBA
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0602E262 RID: 189026 RVA: 0x0064DACA File Offset: 0x0064BCCA
		public static Offset<IFailurePoseInteract> EndIFailurePoseInteract(FlatBufferBuilder builder)
		{
			return new Offset<IFailurePoseInteract>(builder.EndTable());
		}

		// Token: 0x0602E263 RID: 189027 RVA: 0x0064DAD8 File Offset: 0x0064BCD8
		public IFailurePoseInteractT UnPack()
		{
			IFailurePoseInteractT failurePoseInteractT = new IFailurePoseInteractT();
			this.UnPackTo(failurePoseInteractT);
			return failurePoseInteractT;
		}

		// Token: 0x0602E264 RID: 189028 RVA: 0x0064DAF4 File Offset: 0x0064BCF4
		public void UnPackTo(IFailurePoseInteractT _o)
		{
			_o.Type = this.Type;
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0602E265 RID: 189029 RVA: 0x0064DB3C File Offset: 0x0064BD3C
		public static Offset<IFailurePoseInteract> Pack(FlatBufferBuilder builder, IFailurePoseInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailurePoseInteract>);
			}
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IFailurePoseInteract.CreateIFailurePoseInteract(builder, _o.Type, rotOffset);
		}

		// Token: 0x04010EA7 RID: 69287
		private Table __p;
	}
}
