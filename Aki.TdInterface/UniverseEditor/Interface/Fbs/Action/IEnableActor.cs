using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200663C RID: 26172
	public struct IEnableActor : IFlatbufferObject
	{
		// Token: 0x1700C26B RID: 49771
		// (get) Token: 0x0602D72D RID: 186157 RVA: 0x00639B34 File Offset: 0x00637D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D72E RID: 186158 RVA: 0x00639B41 File Offset: 0x00637D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D72F RID: 186159 RVA: 0x00639B48 File Offset: 0x00637D48
		public static IEnableActor GetRootAsIEnableActor(ByteBuffer _bb)
		{
			return IEnableActor.GetRootAsIEnableActor(_bb, default(IEnableActor));
		}

		// Token: 0x0602D730 RID: 186160 RVA: 0x00639B64 File Offset: 0x00637D64
		public static IEnableActor GetRootAsIEnableActor(ByteBuffer _bb, IEnableActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D731 RID: 186161 RVA: 0x00639B81 File Offset: 0x00637D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D732 RID: 186162 RVA: 0x00639B90 File Offset: 0x00637D90
		public IEnableActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C26C RID: 49772
		// (get) Token: 0x0602D733 RID: 186163 RVA: 0x00639BA0 File Offset: 0x00637DA0
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

		// Token: 0x0602D734 RID: 186164 RVA: 0x00639BDC File Offset: 0x00637DDC
		public IActorRef? Targets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C26D RID: 49773
		// (get) Token: 0x0602D735 RID: 186165 RVA: 0x00639C3C File Offset: 0x00637E3C
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

		// Token: 0x1700C26E RID: 49774
		// (get) Token: 0x0602D736 RID: 186166 RVA: 0x00639C68 File Offset: 0x00637E68
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C26F RID: 49775
		// (get) Token: 0x0602D737 RID: 186167 RVA: 0x00639CA8 File Offset: 0x00637EA8
		public bool SyncChildActor
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C270 RID: 49776
		// (get) Token: 0x0602D738 RID: 186168 RVA: 0x00639CE8 File Offset: 0x00637EE8
		public bool CollisionEnabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C271 RID: 49777
		// (get) Token: 0x0602D739 RID: 186169 RVA: 0x00639D28 File Offset: 0x00637F28
		public bool CollisionPreserve
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C272 RID: 49778
		// (get) Token: 0x0602D73A RID: 186170 RVA: 0x00639D68 File Offset: 0x00637F68
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

		// Token: 0x0602D73B RID: 186171 RVA: 0x00639DA8 File Offset: 0x00637FA8
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

		// Token: 0x0602D73C RID: 186172 RVA: 0x00639DF7 File Offset: 0x00637FF7
		public static void StartIEnableActor(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602D73D RID: 186173 RVA: 0x00639E00 File Offset: 0x00638000
		public static void AddActorType(FlatBufferBuilder builder, EActorType actorType)
		{
			builder.AddByte(0, (byte)actorType, 0);
		}

		// Token: 0x0602D73E RID: 186174 RVA: 0x00639E0B File Offset: 0x0063800B
		public static void AddTargets(FlatBufferBuilder builder, VectorOffset targetsOffset)
		{
			builder.AddOffset(1, targetsOffset.Value, 0);
		}

		// Token: 0x0602D73F RID: 186175 RVA: 0x00639E1C File Offset: 0x0063801C
		public static VectorOffset CreateTargetsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D740 RID: 186176 RVA: 0x00639E5C File Offset: 0x0063805C
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D741 RID: 186177 RVA: 0x00639E76 File Offset: 0x00638076
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D742 RID: 186178 RVA: 0x00639E94 File Offset: 0x00638094
		public static VectorOffset CreateTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D743 RID: 186179 RVA: 0x00639EAD File Offset: 0x006380AD
		public static void StartTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D744 RID: 186180 RVA: 0x00639EB8 File Offset: 0x006380B8
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(2, enable, false);
		}

		// Token: 0x0602D745 RID: 186181 RVA: 0x00639EC3 File Offset: 0x006380C3
		public static void AddSyncChildActor(FlatBufferBuilder builder, bool syncChildActor)
		{
			builder.AddBool(3, syncChildActor, false);
		}

		// Token: 0x0602D746 RID: 186182 RVA: 0x00639ECE File Offset: 0x006380CE
		public static void AddCollisionEnabled(FlatBufferBuilder builder, bool collisionEnabled)
		{
			builder.AddBool(4, collisionEnabled, false);
		}

		// Token: 0x0602D747 RID: 186183 RVA: 0x00639ED9 File Offset: 0x006380D9
		public static void AddCollisionPreserve(FlatBufferBuilder builder, bool collisionPreserve)
		{
			builder.AddBool(5, collisionPreserve, false);
		}

		// Token: 0x0602D748 RID: 186184 RVA: 0x00639EE4 File Offset: 0x006380E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602D749 RID: 186185 RVA: 0x00639EEF File Offset: 0x006380EF
		public static Offset<IEnableActor> EndIEnableActor(FlatBufferBuilder builder)
		{
			return new Offset<IEnableActor>(builder.EndTable());
		}

		// Token: 0x0602D74A RID: 186186 RVA: 0x00639EFC File Offset: 0x006380FC
		public IEnableActorT UnPack()
		{
			IEnableActorT enableActorT = new IEnableActorT();
			this.UnPackTo(enableActorT);
			return enableActorT;
		}

		// Token: 0x0602D74B RID: 186187 RVA: 0x00639F18 File Offset: 0x00638118
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

		// Token: 0x0602D74C RID: 186188 RVA: 0x00639FC0 File Offset: 0x006381C0
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

		// Token: 0x04010CD2 RID: 68818
		private Table __p;
	}
}
