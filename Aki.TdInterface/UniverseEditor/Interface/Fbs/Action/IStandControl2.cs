using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AB RID: 29099
	public struct IStandControl2 : IFlatbufferObject
	{
		// Token: 0x1700D819 RID: 55321
		// (get) Token: 0x06033978 RID: 211320 RVA: 0x006F29B5 File Offset: 0x006F0BB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033979 RID: 211321 RVA: 0x006F29C2 File Offset: 0x006F0BC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603397A RID: 211322 RVA: 0x006F29CC File Offset: 0x006F0BCC
		public static IStandControl2 GetRootAsIStandControl2(ByteBuffer _bb)
		{
			return IStandControl2.GetRootAsIStandControl2(_bb, default(IStandControl2));
		}

		// Token: 0x0603397B RID: 211323 RVA: 0x006F29E8 File Offset: 0x006F0BE8
		public static IStandControl2 GetRootAsIStandControl2(ByteBuffer _bb, IStandControl2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603397C RID: 211324 RVA: 0x006F2A05 File Offset: 0x006F0C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603397D RID: 211325 RVA: 0x006F2A14 File Offset: 0x006F0C14
		public IStandControl2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D81A RID: 55322
		// (get) Token: 0x0603397E RID: 211326 RVA: 0x006F2A24 File Offset: 0x006F0C24
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

		// Token: 0x0603397F RID: 211327 RVA: 0x006F2A60 File Offset: 0x006F0C60
		public static Offset<IStandControl2> CreateIStandControl2(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IStandControl2.AddType(builder, Type);
			return IStandControl2.EndIStandControl2(builder);
		}

		// Token: 0x06033980 RID: 211328 RVA: 0x006F2A76 File Offset: 0x006F0C76
		public static void StartIStandControl2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033981 RID: 211329 RVA: 0x006F2A7F File Offset: 0x006F0C7F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033982 RID: 211330 RVA: 0x006F2A8A File Offset: 0x006F0C8A
		public static Offset<IStandControl2> EndIStandControl2(FlatBufferBuilder builder)
		{
			return new Offset<IStandControl2>(builder.EndTable());
		}

		// Token: 0x06033983 RID: 211331 RVA: 0x006F2A98 File Offset: 0x006F0C98
		public IStandControl2T UnPack()
		{
			IStandControl2T standControl2T = new IStandControl2T();
			this.UnPackTo(standControl2T);
			return standControl2T;
		}

		// Token: 0x06033984 RID: 211332 RVA: 0x006F2AB3 File Offset: 0x006F0CB3
		public void UnPackTo(IStandControl2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033985 RID: 211333 RVA: 0x006F2AC4 File Offset: 0x006F0CC4
		public static Offset<IStandControl2> Pack(FlatBufferBuilder builder, IStandControl2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IStandControl2>);
			}
			return IStandControl2.CreateIStandControl2(builder, _o.Type);
		}

		// Token: 0x04011C73 RID: 72819
		private Table __p;
	}
}
