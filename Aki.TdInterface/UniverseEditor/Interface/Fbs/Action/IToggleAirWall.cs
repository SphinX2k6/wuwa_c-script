using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD5 RID: 31701
	public struct IToggleAirWall : IFlatbufferObject
	{
		// Token: 0x1700ED78 RID: 60792
		// (get) Token: 0x06039228 RID: 234024 RVA: 0x007B870E File Offset: 0x007B690E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039229 RID: 234025 RVA: 0x007B871B File Offset: 0x007B691B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603922A RID: 234026 RVA: 0x007B8724 File Offset: 0x007B6924
		public static IToggleAirWall GetRootAsIToggleAirWall(ByteBuffer _bb)
		{
			return IToggleAirWall.GetRootAsIToggleAirWall(_bb, default(IToggleAirWall));
		}

		// Token: 0x0603922B RID: 234027 RVA: 0x007B8740 File Offset: 0x007B6940
		public static IToggleAirWall GetRootAsIToggleAirWall(ByteBuffer _bb, IToggleAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603922C RID: 234028 RVA: 0x007B875D File Offset: 0x007B695D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603922D RID: 234029 RVA: 0x007B876C File Offset: 0x007B696C
		public IToggleAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED79 RID: 60793
		// (get) Token: 0x0603922E RID: 234030 RVA: 0x007B877C File Offset: 0x007B697C
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

		// Token: 0x0603922F RID: 234031 RVA: 0x007B87B8 File Offset: 0x007B69B8
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039230 RID: 234032 RVA: 0x007B87FC File Offset: 0x007B69FC
		public ICloseAirWall OptionAsICloseAirWall()
		{
			return this.Option<ICloseAirWall>().Value;
		}

		// Token: 0x06039231 RID: 234033 RVA: 0x007B8818 File Offset: 0x007B6A18
		public IOpenAirWall OptionAsIOpenAirWall()
		{
			return this.Option<IOpenAirWall>().Value;
		}

		// Token: 0x06039232 RID: 234034 RVA: 0x007B8834 File Offset: 0x007B6A34
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ED7A RID: 60794
		// (get) Token: 0x06039233 RID: 234035 RVA: 0x007B8894 File Offset: 0x007B6A94
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

		// Token: 0x06039234 RID: 234036 RVA: 0x007B88BF File Offset: 0x007B6ABF
		public static Offset<IToggleAirWall> CreateIToggleAirWall(FlatBufferBuilder builder, TToggleAirWall Option_type = TToggleAirWall.NONE, int OptionOffset = 0, VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IToggleAirWall.AddActorRefs(builder, ActorRefsOffset);
			IToggleAirWall.AddOption(builder, OptionOffset);
			IToggleAirWall.AddOptionType(builder, Option_type);
			return IToggleAirWall.EndIToggleAirWall(builder);
		}

		// Token: 0x06039235 RID: 234037 RVA: 0x007B88E3 File Offset: 0x007B6AE3
		public static void StartIToggleAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039236 RID: 234038 RVA: 0x007B88EC File Offset: 0x007B6AEC
		public static void AddOptionType(FlatBufferBuilder builder, TToggleAirWall optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x06039237 RID: 234039 RVA: 0x007B88F7 File Offset: 0x007B6AF7
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x06039238 RID: 234040 RVA: 0x007B8902 File Offset: 0x007B6B02
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x06039239 RID: 234041 RVA: 0x007B8914 File Offset: 0x007B6B14
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603923A RID: 234042 RVA: 0x007B8954 File Offset: 0x007B6B54
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603923B RID: 234043 RVA: 0x007B896E File Offset: 0x007B6B6E
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603923C RID: 234044 RVA: 0x007B898C File Offset: 0x007B6B8C
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603923D RID: 234045 RVA: 0x007B89A5 File Offset: 0x007B6BA5
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603923E RID: 234046 RVA: 0x007B89B0 File Offset: 0x007B6BB0
		public static Offset<IToggleAirWall> EndIToggleAirWall(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAirWall>(builder.EndTable());
		}

		// Token: 0x0603923F RID: 234047 RVA: 0x007B89C0 File Offset: 0x007B6BC0
		public IToggleAirWallT UnPack()
		{
			IToggleAirWallT toggleAirWallT = new IToggleAirWallT();
			this.UnPackTo(toggleAirWallT);
			return toggleAirWallT;
		}

		// Token: 0x06039240 RID: 234048 RVA: 0x007B89DC File Offset: 0x007B6BDC
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

		// Token: 0x06039241 RID: 234049 RVA: 0x007B8ADC File Offset: 0x007B6CDC
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

		// Token: 0x04013261 RID: 78433
		private Table __p;
	}
}
