using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EB RID: 29675
	public struct IToggleAirWall : IFlatbufferObject
	{
		// Token: 0x1700E163 RID: 57699
		// (get) Token: 0x06035E75 RID: 220789 RVA: 0x00755F9A File Offset: 0x0075419A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E76 RID: 220790 RVA: 0x00755FA7 File Offset: 0x007541A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E77 RID: 220791 RVA: 0x00755FB0 File Offset: 0x007541B0
		public static IToggleAirWall GetRootAsIToggleAirWall(ByteBuffer _bb)
		{
			return IToggleAirWall.GetRootAsIToggleAirWall(_bb, default(IToggleAirWall));
		}

		// Token: 0x06035E78 RID: 220792 RVA: 0x00755FCC File Offset: 0x007541CC
		public static IToggleAirWall GetRootAsIToggleAirWall(ByteBuffer _bb, IToggleAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E79 RID: 220793 RVA: 0x00755FE9 File Offset: 0x007541E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E7A RID: 220794 RVA: 0x00755FF8 File Offset: 0x007541F8
		public IToggleAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E164 RID: 57700
		// (get) Token: 0x06035E7B RID: 220795 RVA: 0x00756008 File Offset: 0x00754208
		public TToggleAirWall OptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TToggleAirWall.NONE;
				}
				return (TToggleAirWall)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035E7C RID: 220796 RVA: 0x00756044 File Offset: 0x00754244
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035E7D RID: 220797 RVA: 0x00756088 File Offset: 0x00754288
		public ICloseAirWall OptionAsICloseAirWall()
		{
			return this.Option<ICloseAirWall>().Value;
		}

		// Token: 0x06035E7E RID: 220798 RVA: 0x007560A4 File Offset: 0x007542A4
		public IOpenAirWall OptionAsIOpenAirWall()
		{
			return this.Option<IOpenAirWall>().Value;
		}

		// Token: 0x06035E7F RID: 220799 RVA: 0x007560C0 File Offset: 0x007542C0
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E165 RID: 57701
		// (get) Token: 0x06035E80 RID: 220800 RVA: 0x00756120 File Offset: 0x00754320
		public int ActorRefsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06035E81 RID: 220801 RVA: 0x0075614B File Offset: 0x0075434B
		public static Offset<IToggleAirWall> CreateIToggleAirWall(FlatBufferBuilder builder, TToggleAirWall Option_type = TToggleAirWall.NONE, int OptionOffset = 0, VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IToggleAirWall.AddActorRefs(builder, ActorRefsOffset);
			IToggleAirWall.AddOption(builder, OptionOffset);
			IToggleAirWall.AddOptionType(builder, Option_type);
			return IToggleAirWall.EndIToggleAirWall(builder);
		}

		// Token: 0x06035E82 RID: 220802 RVA: 0x0075616F File Offset: 0x0075436F
		public static void StartIToggleAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035E83 RID: 220803 RVA: 0x00756178 File Offset: 0x00754378
		public static void AddOptionType(FlatBufferBuilder builder, TToggleAirWall optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x06035E84 RID: 220804 RVA: 0x00756183 File Offset: 0x00754383
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x06035E85 RID: 220805 RVA: 0x0075618E File Offset: 0x0075438E
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x06035E86 RID: 220806 RVA: 0x007561A0 File Offset: 0x007543A0
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035E87 RID: 220807 RVA: 0x007561E0 File Offset: 0x007543E0
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035E88 RID: 220808 RVA: 0x007561FA File Offset: 0x007543FA
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035E89 RID: 220809 RVA: 0x00756218 File Offset: 0x00754418
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035E8A RID: 220810 RVA: 0x00756231 File Offset: 0x00754431
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035E8B RID: 220811 RVA: 0x0075623C File Offset: 0x0075443C
		public static Offset<IToggleAirWall> EndIToggleAirWall(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAirWall>(builder.EndTable());
		}

		// Token: 0x06035E8C RID: 220812 RVA: 0x0075624C File Offset: 0x0075444C
		public IToggleAirWallT UnPack()
		{
			IToggleAirWallT toggleAirWallT = new IToggleAirWallT();
			this.UnPackTo(toggleAirWallT);
			return toggleAirWallT;
		}

		// Token: 0x06035E8D RID: 220813 RVA: 0x00756268 File Offset: 0x00754468
		public void UnPackTo(IToggleAirWallT _o)
		{
			_o.Option = new TToggleAirWallUnion();
			_o.Option.Type = this.OptionType;
			TToggleAirWall optionType = this.OptionType;
			if (optionType != TToggleAirWall.ICloseAirWall)
			{
				if (optionType == TToggleAirWall.IOpenAirWall)
				{
					_o.Option.Value = ((this.Option<IOpenAirWall>() != null) ? this.Option<IOpenAirWall>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Option.Value = ((this.Option<ICloseAirWall>() != null) ? this.Option<ICloseAirWall>().Value.UnPack() : null);
			}
			_o.ActorRefs = new List<IActorRefT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035E8E RID: 220814 RVA: 0x00756368 File Offset: 0x00754568
		public static Offset<IToggleAirWall> Pack(FlatBufferBuilder builder, IToggleAirWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleAirWall>);
			}
			TToggleAirWall option_type = (_o.Option == null) ? TToggleAirWall.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TToggleAirWallUnion.Pack(builder, _o.Option);
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IToggleAirWall.CreateActorRefsVector(builder, array);
			}
			return IToggleAirWall.CreateIToggleAirWall(builder, option_type, optionOffset, actorRefsOffset);
		}

		// Token: 0x04012245 RID: 74309
		private Table __p;
	}
}
