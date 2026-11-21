using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C77 RID: 27767
	public struct IDragActor : IFlatbufferObject
	{
		// Token: 0x1700CBAA RID: 52138
		// (get) Token: 0x0602FD5C RID: 195932 RVA: 0x00683B4E File Offset: 0x00681D4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD5D RID: 195933 RVA: 0x00683B5B File Offset: 0x00681D5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD5E RID: 195934 RVA: 0x00683B64 File Offset: 0x00681D64
		public static IDragActor GetRootAsIDragActor(ByteBuffer _bb)
		{
			return IDragActor.GetRootAsIDragActor(_bb, default(IDragActor));
		}

		// Token: 0x0602FD5F RID: 195935 RVA: 0x00683B80 File Offset: 0x00681D80
		public static IDragActor GetRootAsIDragActor(ByteBuffer _bb, IDragActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD60 RID: 195936 RVA: 0x00683B9D File Offset: 0x00681D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD61 RID: 195937 RVA: 0x00683BAC File Offset: 0x00681DAC
		public IDragActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBAB RID: 52139
		// (get) Token: 0x0602FD62 RID: 195938 RVA: 0x00683BBC File Offset: 0x00681DBC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBAC RID: 52140
		// (get) Token: 0x0602FD63 RID: 195939 RVA: 0x00683BF8 File Offset: 0x00681DF8
		public int TargetEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FD64 RID: 195940 RVA: 0x00683C34 File Offset: 0x00681E34
		public static Offset<IDragActor> CreateIDragActor(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int TargetEntityId = 0)
		{
			builder.StartTable(2);
			IDragActor.AddTargetEntityId(builder, TargetEntityId);
			IDragActor.AddType(builder, Type);
			return IDragActor.EndIDragActor(builder);
		}

		// Token: 0x0602FD65 RID: 195941 RVA: 0x00683C51 File Offset: 0x00681E51
		public static void StartIDragActor(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FD66 RID: 195942 RVA: 0x00683C5A File Offset: 0x00681E5A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD67 RID: 195943 RVA: 0x00683C65 File Offset: 0x00681E65
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0602FD68 RID: 195944 RVA: 0x00683C70 File Offset: 0x00681E70
		public static Offset<IDragActor> EndIDragActor(FlatBufferBuilder builder)
		{
			return new Offset<IDragActor>(builder.EndTable());
		}

		// Token: 0x0602FD69 RID: 195945 RVA: 0x00683C80 File Offset: 0x00681E80
		public IDragActorT UnPack()
		{
			IDragActorT dragActorT = new IDragActorT();
			this.UnPackTo(dragActorT);
			return dragActorT;
		}

		// Token: 0x0602FD6A RID: 195946 RVA: 0x00683C9B File Offset: 0x00681E9B
		public void UnPackTo(IDragActorT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x0602FD6B RID: 195947 RVA: 0x00683CB8 File Offset: 0x00681EB8
		public static Offset<IDragActor> Pack(FlatBufferBuilder builder, IDragActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragActor>);
			}
			return IDragActor.CreateIDragActor(builder, _o.Type, _o.TargetEntityId);
		}

		// Token: 0x04011AA5 RID: 72357
		private Table __p;
	}
}
