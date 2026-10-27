using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005246 RID: 21062
	public struct IFightMusicsSwitchType : IFlatbufferObject
	{
		// Token: 0x17009A52 RID: 39506
		// (get) Token: 0x06022431 RID: 140337 RVA: 0x004C0898 File Offset: 0x004BEA98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022432 RID: 140338 RVA: 0x004C08A5 File Offset: 0x004BEAA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022433 RID: 140339 RVA: 0x004C08AC File Offset: 0x004BEAAC
		public static IFightMusicsSwitchType GetRootAsIFightMusicsSwitchType(ByteBuffer _bb)
		{
			return IFightMusicsSwitchType.GetRootAsIFightMusicsSwitchType(_bb, default(IFightMusicsSwitchType));
		}

		// Token: 0x06022434 RID: 140340 RVA: 0x004C08C8 File Offset: 0x004BEAC8
		public static IFightMusicsSwitchType GetRootAsIFightMusicsSwitchType(ByteBuffer _bb, IFightMusicsSwitchType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x004C08E5 File Offset: 0x004BEAE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x004C08F4 File Offset: 0x004BEAF4
		public IFightMusicsSwitchType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A53 RID: 39507
		// (get) Token: 0x06022437 RID: 140343 RVA: 0x004C0904 File Offset: 0x004BEB04
		public EFightMusicsSwitchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return (EFightMusicsSwitchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022438 RID: 140344 RVA: 0x004C0940 File Offset: 0x004BEB40
		public static Offset<IFightMusicsSwitchType> CreateIFightMusicsSwitchType(FlatBufferBuilder builder, EFightMusicsSwitchType Type = EFightMusicsSwitchType.SwitchByTag)
		{
			builder.StartTable(1);
			IFightMusicsSwitchType.AddType(builder, Type);
			return IFightMusicsSwitchType.EndIFightMusicsSwitchType(builder);
		}

		// Token: 0x06022439 RID: 140345 RVA: 0x004C0956 File Offset: 0x004BEB56
		public static void StartIFightMusicsSwitchType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602243A RID: 140346 RVA: 0x004C095F File Offset: 0x004BEB5F
		public static void AddType(FlatBufferBuilder builder, EFightMusicsSwitchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602243B RID: 140347 RVA: 0x004C096A File Offset: 0x004BEB6A
		public static Offset<IFightMusicsSwitchType> EndIFightMusicsSwitchType(FlatBufferBuilder builder)
		{
			return new Offset<IFightMusicsSwitchType>(builder.EndTable());
		}

		// Token: 0x0602243C RID: 140348 RVA: 0x004C0978 File Offset: 0x004BEB78
		public IFightMusicsSwitchTypeT UnPack()
		{
			IFightMusicsSwitchTypeT fightMusicsSwitchTypeT = new IFightMusicsSwitchTypeT();
			this.UnPackTo(fightMusicsSwitchTypeT);
			return fightMusicsSwitchTypeT;
		}

		// Token: 0x0602243D RID: 140349 RVA: 0x004C0993 File Offset: 0x004BEB93
		public void UnPackTo(IFightMusicsSwitchTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602243E RID: 140350 RVA: 0x004C09A4 File Offset: 0x004BEBA4
		public static Offset<IFightMusicsSwitchType> Pack(FlatBufferBuilder builder, IFightMusicsSwitchTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFightMusicsSwitchType>);
			}
			return IFightMusicsSwitchType.CreateIFightMusicsSwitchType(builder, _o.Type);
		}

		// Token: 0x0400E392 RID: 58258
		private Table __p;
	}
}
