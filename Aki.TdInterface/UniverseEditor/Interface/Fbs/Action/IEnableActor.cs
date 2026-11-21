using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAD RID: 27821
	public struct IEnableActor : IFlatbufferObject
	{
		// Token: 0x1700CC09 RID: 52233
		// (get) Token: 0x0602FEFE RID: 196350 RVA: 0x0068669C File Offset: 0x0068489C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FEFF RID: 196351 RVA: 0x006866A9 File Offset: 0x006848A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF00 RID: 196352 RVA: 0x006866B0 File Offset: 0x006848B0
		public static IEnableActor GetRootAsIEnableActor(ByteBuffer _bb)
		{
			return IEnableActor.GetRootAsIEnableActor(_bb, default(IEnableActor));
		}

		// Token: 0x0602FF01 RID: 196353 RVA: 0x006866CC File Offset: 0x006848CC
		public static IEnableActor GetRootAsIEnableActor(ByteBuffer _bb, IEnableActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF02 RID: 196354 RVA: 0x006866E9 File Offset: 0x006848E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF03 RID: 196355 RVA: 0x006866F8 File Offset: 0x006848F8
		public IEnableActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC0A RID: 52234
		// (get) Token: 0x0602FF04 RID: 196356 RVA: 0x00686708 File Offset: 0x00684908
		public EActorType ActorType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorType.MeshActor;
				}
				return (EActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FF05 RID: 196357 RVA: 0x00686744 File Offset: 0x00684944
		public IActorRef? Targets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CC0B RID: 52235
		// (get) Token: 0x0602FF06 RID: 196358 RVA: 0x006867A4 File Offset: 0x006849A4
		public int TargetsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CC0C RID: 52236
		// (get) Token: 0x0602FF07 RID: 196359 RVA: 0x006867D0 File Offset: 0x006849D0
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC0D RID: 52237
		// (get) Token: 0x0602FF08 RID: 196360 RVA: 0x00686810 File Offset: 0x00684A10
		public bool SyncChildActor
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC0E RID: 52238
		// (get) Token: 0x0602FF09 RID: 196361 RVA: 0x00686850 File Offset: 0x00684A50
		public bool CollisionEnabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC0F RID: 52239
		// (get) Token: 0x0602FF0A RID: 196362 RVA: 0x00686890 File Offset: 0x00684A90
		public bool CollisionPreserve
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC10 RID: 52240
		// (get) Token: 0x0602FF0B RID: 196363 RVA: 0x006868D0 File Offset: 0x00684AD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FF0C RID: 196364 RVA: 0x00686910 File Offset: 0x00684B10
		public static Offset<IEnableActor> CreateIEnableActor(FlatBufferBuilder builder, EActorType ActorType = EActorType.MeshActor, VectorOffset TargetsOffset = default(VectorOffset), bool Enable = false, bool SyncChildActor = false, bool CollisionEnabled = false, bool CollisionPreserve = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IEnableActor.AddTargets(builder, TargetsOffset);
			IEnableActor.AddNullMask(builder, NullMask);
			IEnableActor.AddCollisionPreserve(builder, CollisionPreserve);
			IEnableActor.AddCollisionEnabled(builder, CollisionEnabled);
			IEnableActor.AddSyncChildActor(builder, SyncChildActor);
			IEnableActor.AddEnable(builder, Enable);
			IEnableActor.AddActorType(builder, ActorType);
			return IEnableActor.EndIEnableActor(builder);
		}

		// Token: 0x0602FF0D RID: 196365 RVA: 0x0068695F File Offset: 0x00684B5F
		public static void StartIEnableActor(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602FF0E RID: 196366 RVA: 0x00686968 File Offset: 0x00684B68
		public static void AddActorType(FlatBufferBuilder builder, EActorType actorType)
		{
			builder.AddByte(0, (byte)actorType, 0);
		}

		// Token: 0x0602FF0F RID: 196367 RVA: 0x00686973 File Offset: 0x00684B73
		public static void AddTargets(FlatBufferBuilder builder, VectorOffset targetsOffset)
		{
			builder.AddOffset(1, targetsOffset.Value, 0);
		}

		// Token: 0x0602FF10 RID: 196368 RVA: 0x00686984 File Offset: 0x00684B84
		public static VectorOffset CreateTargetsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FF11 RID: 196369 RVA: 0x006869C4 File Offset: 0x00684BC4
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FF12 RID: 196370 RVA: 0x006869DE File Offset: 0x00684BDE
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FF13 RID: 196371 RVA: 0x006869FC File Offset: 0x00684BFC
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FF14 RID: 196372 RVA: 0x00686A15 File Offset: 0x00684C15
		public static void StartTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FF15 RID: 196373 RVA: 0x00686A20 File Offset: 0x00684C20
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(2, enable, false);
		}

		// Token: 0x0602FF16 RID: 196374 RVA: 0x00686A2B File Offset: 0x00684C2B
		public static void AddSyncChildActor(FlatBufferBuilder builder, bool syncChildActor)
		{
			builder.AddBool(3, syncChildActor, false);
		}

		// Token: 0x0602FF17 RID: 196375 RVA: 0x00686A36 File Offset: 0x00684C36
		public static void AddCollisionEnabled(FlatBufferBuilder builder, bool collisionEnabled)
		{
			builder.AddBool(4, collisionEnabled, false);
		}

		// Token: 0x0602FF18 RID: 196376 RVA: 0x00686A41 File Offset: 0x00684C41
		public static void AddCollisionPreserve(FlatBufferBuilder builder, bool collisionPreserve)
		{
			builder.AddBool(5, collisionPreserve, false);
		}

		// Token: 0x0602FF19 RID: 196377 RVA: 0x00686A4C File Offset: 0x00684C4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602FF1A RID: 196378 RVA: 0x00686A57 File Offset: 0x00684C57
		public static Offset<IEnableActor> EndIEnableActor(FlatBufferBuilder builder)
		{
			return new Offset<IEnableActor>(builder.EndTable());
		}

		// Token: 0x0602FF1B RID: 196379 RVA: 0x00686A64 File Offset: 0x00684C64
		public IEnableActorT UnPack()
		{
			IEnableActorT enableActorT = new IEnableActorT();
			this.UnPackTo(enableActorT);
			return enableActorT;
		}

		// Token: 0x0602FF1C RID: 196380 RVA: 0x00686A80 File Offset: 0x00684C80
		public void UnPackTo(IEnableActorT _o)
		{
			_o.ActorType = this.ActorType;
			_o.Targets = new List<IActorRefT>();
			for (int i = 0; i < this.TargetsLength; i++)
			{
				_o.Targets.Add((this.Targets(i) != null) ? this.Targets(i).Value.UnPack() : null);
			}
			_o.Enable = this.Enable;
			_o.SyncChildActor = this.SyncChildActor;
			_o.CollisionEnabled = this.CollisionEnabled;
			_o.CollisionPreserve = this.CollisionPreserve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FF1D RID: 196381 RVA: 0x00686B28 File Offset: 0x00684D28
		public static Offset<IEnableActor> Pack(FlatBufferBuilder builder, IEnableActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableActor>);
			}
			VectorOffset targetsOffset = default(VectorOffset);
			if (_o.Targets != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.Targets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.Targets[i]);
				}
				targetsOffset = IEnableActor.CreateTargetsVector(builder, array);
			}
			return IEnableActor.CreateIEnableActor(builder, _o.ActorType, targetsOffset, _o.Enable, _o.SyncChildActor, _o.CollisionEnabled, _o.CollisionPreserve, _o.NullMask);
		}

		// Token: 0x04011AED RID: 72429
		private Table __p;
	}
}
