using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D1 RID: 25809
	public struct IControlElementalBoxTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C012 RID: 49170
		// (get) Token: 0x0602CC56 RID: 183382 RVA: 0x00627331 File Offset: 0x00625531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC57 RID: 183383 RVA: 0x0062733E File Offset: 0x0062553E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC58 RID: 183384 RVA: 0x00627348 File Offset: 0x00625548
		public static IControlElementalBoxTypeBase GetRootAsIControlElementalBoxTypeBase(ByteBuffer _bb)
		{
			return IControlElementalBoxTypeBase.GetRootAsIControlElementalBoxTypeBase(_bb, default(IControlElementalBoxTypeBase));
		}

		// Token: 0x0602CC59 RID: 183385 RVA: 0x00627364 File Offset: 0x00625564
		public static IControlElementalBoxTypeBase GetRootAsIControlElementalBoxTypeBase(ByteBuffer _bb, IControlElementalBoxTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC5A RID: 183386 RVA: 0x00627381 File Offset: 0x00625581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC5B RID: 183387 RVA: 0x00627390 File Offset: 0x00625590
		public IControlElementalBoxTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C013 RID: 49171
		// (get) Token: 0x0602CC5C RID: 183388 RVA: 0x006273A0 File Offset: 0x006255A0
		public EControlElementalBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlElementalBoxType.Capture;
				}
				return (EControlElementalBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CC5D RID: 183389 RVA: 0x006273DC File Offset: 0x006255DC
		public static Offset<IControlElementalBoxTypeBase> CreateIControlElementalBoxTypeBase(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture)
		{
			builder.StartTable(1);
			IControlElementalBoxTypeBase.AddType(builder, Type);
			return IControlElementalBoxTypeBase.EndIControlElementalBoxTypeBase(builder);
		}

		// Token: 0x0602CC5E RID: 183390 RVA: 0x006273F2 File Offset: 0x006255F2
		public static void StartIControlElementalBoxTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CC5F RID: 183391 RVA: 0x006273FB File Offset: 0x006255FB
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC60 RID: 183392 RVA: 0x00627406 File Offset: 0x00625606
		public static Offset<IControlElementalBoxTypeBase> EndIControlElementalBoxTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxTypeBase>(builder.EndTable());
		}

		// Token: 0x0602CC61 RID: 183393 RVA: 0x00627414 File Offset: 0x00625614
		public IControlElementalBoxTypeBaseT UnPack()
		{
			IControlElementalBoxTypeBaseT controlElementalBoxTypeBaseT = new IControlElementalBoxTypeBaseT();
			this.UnPackTo(controlElementalBoxTypeBaseT);
			return controlElementalBoxTypeBaseT;
		}

		// Token: 0x0602CC62 RID: 183394 RVA: 0x0062742F File Offset: 0x0062562F
		public void UnPackTo(IControlElementalBoxTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CC63 RID: 183395 RVA: 0x00627440 File Offset: 0x00625640
		public static Offset<IControlElementalBoxTypeBase> Pack(FlatBufferBuilder builder, IControlElementalBoxTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxTypeBase>);
			}
			return IControlElementalBoxTypeBase.CreateIControlElementalBoxTypeBase(builder, _o.Type);
		}

		// Token: 0x04010B09 RID: 68361
		private Table __p;
	}
}
