using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004706 RID: 18182
	public struct IWordArtResourceType : IFlatbufferObject
	{
		// Token: 0x17007F52 RID: 32594
		// (get) Token: 0x0601AC01 RID: 109569 RVA: 0x003CCE8A File Offset: 0x003CB08A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AC02 RID: 109570 RVA: 0x003CCE97 File Offset: 0x003CB097
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AC03 RID: 109571 RVA: 0x003CCEA0 File Offset: 0x003CB0A0
		public static IWordArtResourceType GetRootAsIWordArtResourceType(ByteBuffer _bb)
		{
			return IWordArtResourceType.GetRootAsIWordArtResourceType(_bb, default(IWordArtResourceType));
		}

		// Token: 0x0601AC04 RID: 109572 RVA: 0x003CCEBC File Offset: 0x003CB0BC
		public static IWordArtResourceType GetRootAsIWordArtResourceType(ByteBuffer _bb, IWordArtResourceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AC05 RID: 109573 RVA: 0x003CCED9 File Offset: 0x003CB0D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AC06 RID: 109574 RVA: 0x003CCEE8 File Offset: 0x003CB0E8
		public IWordArtResourceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F53 RID: 32595
		// (get) Token: 0x0601AC07 RID: 109575 RVA: 0x003CCEF8 File Offset: 0x003CB0F8
		public EWordArtResourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWordArtResourceType.Default;
				}
				return (EWordArtResourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AC08 RID: 109576 RVA: 0x003CCF34 File Offset: 0x003CB134
		public static Offset<IWordArtResourceType> CreateIWordArtResourceType(FlatBufferBuilder builder, EWordArtResourceType Type = EWordArtResourceType.Default)
		{
			builder.StartTable(1);
			IWordArtResourceType.AddType(builder, Type);
			return IWordArtResourceType.EndIWordArtResourceType(builder);
		}

		// Token: 0x0601AC09 RID: 109577 RVA: 0x003CCF4A File Offset: 0x003CB14A
		public static void StartIWordArtResourceType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AC0A RID: 109578 RVA: 0x003CCF53 File Offset: 0x003CB153
		public static void AddType(FlatBufferBuilder builder, EWordArtResourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AC0B RID: 109579 RVA: 0x003CCF5E File Offset: 0x003CB15E
		public static Offset<IWordArtResourceType> EndIWordArtResourceType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtResourceType>(builder.EndTable());
		}

		// Token: 0x0601AC0C RID: 109580 RVA: 0x003CCF6C File Offset: 0x003CB16C
		public IWordArtResourceTypeT UnPack()
		{
			IWordArtResourceTypeT wordArtResourceTypeT = new IWordArtResourceTypeT();
			this.UnPackTo(wordArtResourceTypeT);
			return wordArtResourceTypeT;
		}

		// Token: 0x0601AC0D RID: 109581 RVA: 0x003CCF87 File Offset: 0x003CB187
		public void UnPackTo(IWordArtResourceTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AC0E RID: 109582 RVA: 0x003CCF98 File Offset: 0x003CB198
		public static Offset<IWordArtResourceType> Pack(FlatBufferBuilder builder, IWordArtResourceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtResourceType>);
			}
			return IWordArtResourceType.CreateIWordArtResourceType(builder, _o.Type);
		}

		// Token: 0x0400C95B RID: 51547
		private Table __p;
	}
}
