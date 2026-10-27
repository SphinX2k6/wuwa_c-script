using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD0 RID: 23504
	public struct IWuWaGoPullRod : IFlatbufferObject
	{
		// Token: 0x1700B19A RID: 45466
		// (get) Token: 0x0602844F RID: 164943 RVA: 0x0058871E File Offset: 0x0058691E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028450 RID: 164944 RVA: 0x0058872B File Offset: 0x0058692B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028451 RID: 164945 RVA: 0x00588734 File Offset: 0x00586934
		public static IWuWaGoPullRod GetRootAsIWuWaGoPullRod(ByteBuffer _bb)
		{
			return IWuWaGoPullRod.GetRootAsIWuWaGoPullRod(_bb, default(IWuWaGoPullRod));
		}

		// Token: 0x06028452 RID: 164946 RVA: 0x00588750 File Offset: 0x00586950
		public static IWuWaGoPullRod GetRootAsIWuWaGoPullRod(ByteBuffer _bb, IWuWaGoPullRod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028453 RID: 164947 RVA: 0x0058876D File Offset: 0x0058696D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028454 RID: 164948 RVA: 0x0058877C File Offset: 0x0058697C
		public IWuWaGoPullRod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B19B RID: 45467
		// (get) Token: 0x06028455 RID: 164949 RVA: 0x0058878C File Offset: 0x0058698C
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028456 RID: 164950 RVA: 0x005887C8 File Offset: 0x005869C8
		public IWuWaGoInteractStateAction? InteractConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoInteractStateAction?(default(IWuWaGoInteractStateAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B19C RID: 45468
		// (get) Token: 0x06028457 RID: 164951 RVA: 0x00588828 File Offset: 0x00586A28
		public int InteractConfigLength
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

		// Token: 0x06028458 RID: 164952 RVA: 0x00588853 File Offset: 0x00586A53
		public static Offset<IWuWaGoPullRod> CreateIWuWaGoPullRod(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, VectorOffset InteractConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoPullRod.AddInteractConfig(builder, InteractConfigOffset);
			IWuWaGoPullRod.AddType(builder, Type);
			return IWuWaGoPullRod.EndIWuWaGoPullRod(builder);
		}

		// Token: 0x06028459 RID: 164953 RVA: 0x00588870 File Offset: 0x00586A70
		public static void StartIWuWaGoPullRod(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602845A RID: 164954 RVA: 0x00588879 File Offset: 0x00586A79
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602845B RID: 164955 RVA: 0x00588884 File Offset: 0x00586A84
		public static void AddInteractConfig(FlatBufferBuilder builder, VectorOffset interactConfigOffset)
		{
			builder.AddOffset(1, interactConfigOffset.Value, 0);
		}

		// Token: 0x0602845C RID: 164956 RVA: 0x00588894 File Offset: 0x00586A94
		public static VectorOffset CreateInteractConfigVector(FlatBufferBuilder builder, Offset<IWuWaGoInteractStateAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602845D RID: 164957 RVA: 0x005888D4 File Offset: 0x00586AD4
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoInteractStateAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602845E RID: 164958 RVA: 0x005888EE File Offset: 0x00586AEE
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoInteractStateAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602845F RID: 164959 RVA: 0x0058890C File Offset: 0x00586B0C
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028460 RID: 164960 RVA: 0x00588925 File Offset: 0x00586B25
		public static void StartInteractConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028461 RID: 164961 RVA: 0x00588930 File Offset: 0x00586B30
		public static Offset<IWuWaGoPullRod> EndIWuWaGoPullRod(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoPullRod>(builder.EndTable());
		}

		// Token: 0x06028462 RID: 164962 RVA: 0x00588940 File Offset: 0x00586B40
		public IWuWaGoPullRodT UnPack()
		{
			IWuWaGoPullRodT wuWaGoPullRodT = new IWuWaGoPullRodT();
			this.UnPackTo(wuWaGoPullRodT);
			return wuWaGoPullRodT;
		}

		// Token: 0x06028463 RID: 164963 RVA: 0x0058895C File Offset: 0x00586B5C
		public void UnPackTo(IWuWaGoPullRodT _o)
		{
			_o.Type = this.Type;
			_o.InteractConfig = new List<IWuWaGoInteractStateActionT>();
			for (int i = 0; i < this.InteractConfigLength; i++)
			{
				_o.InteractConfig.Add((this.InteractConfig(i) != null) ? this.InteractConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028464 RID: 164964 RVA: 0x005889C8 File Offset: 0x00586BC8
		public static Offset<IWuWaGoPullRod> Pack(FlatBufferBuilder builder, IWuWaGoPullRodT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoPullRod>);
			}
			VectorOffset interactConfigOffset = default(VectorOffset);
			if (_o.InteractConfig != null)
			{
				Offset<IWuWaGoInteractStateAction>[] array = new Offset<IWuWaGoInteractStateAction>[_o.InteractConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IWuWaGoInteractStateAction.Pack(builder, _o.InteractConfig[i]);
				}
				interactConfigOffset = IWuWaGoPullRod.CreateInteractConfigVector(builder, array);
			}
			return IWuWaGoPullRod.CreateIWuWaGoPullRod(builder, _o.Type, interactConfigOffset);
		}

		// Token: 0x0400F34E RID: 62286
		private Table __p;
	}
}
