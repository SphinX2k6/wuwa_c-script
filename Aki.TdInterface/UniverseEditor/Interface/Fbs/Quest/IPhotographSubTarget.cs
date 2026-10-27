using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F83 RID: 16259
	public struct IPhotographSubTarget : IFlatbufferObject
	{
		// Token: 0x1700717E RID: 29054
		// (get) Token: 0x06017370 RID: 95088 RVA: 0x00359842 File Offset: 0x00357A42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017371 RID: 95089 RVA: 0x0035984F File Offset: 0x00357A4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017372 RID: 95090 RVA: 0x00359858 File Offset: 0x00357A58
		public static IPhotographSubTarget GetRootAsIPhotographSubTarget(ByteBuffer _bb)
		{
			return IPhotographSubTarget.GetRootAsIPhotographSubTarget(_bb, default(IPhotographSubTarget));
		}

		// Token: 0x06017373 RID: 95091 RVA: 0x00359874 File Offset: 0x00357A74
		public static IPhotographSubTarget GetRootAsIPhotographSubTarget(ByteBuffer _bb, IPhotographSubTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017374 RID: 95092 RVA: 0x00359891 File Offset: 0x00357A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017375 RID: 95093 RVA: 0x003598A0 File Offset: 0x00357AA0
		public IPhotographSubTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700717F RID: 29055
		// (get) Token: 0x06017376 RID: 95094 RVA: 0x003598B0 File Offset: 0x00357AB0
		public EPhotographSubTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographSubTargetType.SpecificRole;
				}
				return (EPhotographSubTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017377 RID: 95095 RVA: 0x003598EC File Offset: 0x00357AEC
		public static Offset<IPhotographSubTarget> CreateIPhotographSubTarget(FlatBufferBuilder builder, EPhotographSubTargetType Type = EPhotographSubTargetType.SpecificRole)
		{
			builder.StartTable(1);
			IPhotographSubTarget.AddType(builder, Type);
			return IPhotographSubTarget.EndIPhotographSubTarget(builder);
		}

		// Token: 0x06017378 RID: 95096 RVA: 0x00359902 File Offset: 0x00357B02
		public static void StartIPhotographSubTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017379 RID: 95097 RVA: 0x0035990B File Offset: 0x00357B0B
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601737A RID: 95098 RVA: 0x00359916 File Offset: 0x00357B16
		public static Offset<IPhotographSubTarget> EndIPhotographSubTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTarget>(builder.EndTable());
		}

		// Token: 0x0601737B RID: 95099 RVA: 0x00359924 File Offset: 0x00357B24
		public IPhotographSubTargetT UnPack()
		{
			IPhotographSubTargetT photographSubTargetT = new IPhotographSubTargetT();
			this.UnPackTo(photographSubTargetT);
			return photographSubTargetT;
		}

		// Token: 0x0601737C RID: 95100 RVA: 0x0035993F File Offset: 0x00357B3F
		public void UnPackTo(IPhotographSubTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601737D RID: 95101 RVA: 0x00359950 File Offset: 0x00357B50
		public static Offset<IPhotographSubTarget> Pack(FlatBufferBuilder builder, IPhotographSubTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTarget>);
			}
			return IPhotographSubTarget.CreateIPhotographSubTarget(builder, _o.Type);
		}

		// Token: 0x0400B9DA RID: 47578
		private Table __p;
	}
}
