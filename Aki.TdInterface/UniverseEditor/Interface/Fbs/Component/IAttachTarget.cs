using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB9 RID: 20153
	public struct IAttachTarget : IFlatbufferObject
	{
		// Token: 0x17009094 RID: 37012
		// (get) Token: 0x0601FBC8 RID: 129992 RVA: 0x0046B015 File Offset: 0x00469215
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBC9 RID: 129993 RVA: 0x0046B022 File Offset: 0x00469222
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBCA RID: 129994 RVA: 0x0046B02C File Offset: 0x0046922C
		public static IAttachTarget GetRootAsIAttachTarget(ByteBuffer _bb)
		{
			return IAttachTarget.GetRootAsIAttachTarget(_bb, default(IAttachTarget));
		}

		// Token: 0x0601FBCB RID: 129995 RVA: 0x0046B048 File Offset: 0x00469248
		public static IAttachTarget GetRootAsIAttachTarget(ByteBuffer _bb, IAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBCC RID: 129996 RVA: 0x0046B065 File Offset: 0x00469265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBCD RID: 129997 RVA: 0x0046B074 File Offset: 0x00469274
		public IAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009095 RID: 37013
		// (get) Token: 0x0601FBCE RID: 129998 RVA: 0x0046B084 File Offset: 0x00469284
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FBCF RID: 129999 RVA: 0x0046B0C0 File Offset: 0x004692C0
		public static Offset<IAttachTarget> CreateIAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor)
		{
			builder.StartTable(1);
			IAttachTarget.AddType(builder, Type);
			return IAttachTarget.EndIAttachTarget(builder);
		}

		// Token: 0x0601FBD0 RID: 130000 RVA: 0x0046B0D6 File Offset: 0x004692D6
		public static void StartIAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FBD1 RID: 130001 RVA: 0x0046B0DF File Offset: 0x004692DF
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBD2 RID: 130002 RVA: 0x0046B0EA File Offset: 0x004692EA
		public static Offset<IAttachTarget> EndIAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTarget>(builder.EndTable());
		}

		// Token: 0x0601FBD3 RID: 130003 RVA: 0x0046B0F8 File Offset: 0x004692F8
		public IAttachTargetT UnPack()
		{
			IAttachTargetT attachTargetT = new IAttachTargetT();
			this.UnPackTo(attachTargetT);
			return attachTargetT;
		}

		// Token: 0x0601FBD4 RID: 130004 RVA: 0x0046B113 File Offset: 0x00469313
		public void UnPackTo(IAttachTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FBD5 RID: 130005 RVA: 0x0046B124 File Offset: 0x00469324
		public static Offset<IAttachTarget> Pack(FlatBufferBuilder builder, IAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTarget>);
			}
			return IAttachTarget.CreateIAttachTarget(builder, _o.Type);
		}

		// Token: 0x0400DCA1 RID: 56481
		private Table __p;
	}
}
