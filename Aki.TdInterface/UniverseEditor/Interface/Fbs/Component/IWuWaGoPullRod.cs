using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E6 RID: 25062
	public struct IWuWaGoPullRod : IFlatbufferObject
	{
		// Token: 0x1700BAE2 RID: 47842
		// (get) Token: 0x0602AA13 RID: 174611 RVA: 0x005D01AE File Offset: 0x005CE3AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA14 RID: 174612 RVA: 0x005D01BB File Offset: 0x005CE3BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA15 RID: 174613 RVA: 0x005D01C4 File Offset: 0x005CE3C4
		public static IWuWaGoPullRod GetRootAsIWuWaGoPullRod(ByteBuffer _bb)
		{
			return IWuWaGoPullRod.GetRootAsIWuWaGoPullRod(_bb, default(IWuWaGoPullRod));
		}

		// Token: 0x0602AA16 RID: 174614 RVA: 0x005D01E0 File Offset: 0x005CE3E0
		public static IWuWaGoPullRod GetRootAsIWuWaGoPullRod(ByteBuffer _bb, IWuWaGoPullRod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA17 RID: 174615 RVA: 0x005D01FD File Offset: 0x005CE3FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA18 RID: 174616 RVA: 0x005D020C File Offset: 0x005CE40C
		public IWuWaGoPullRod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAE3 RID: 47843
		// (get) Token: 0x0602AA19 RID: 174617 RVA: 0x005D021C File Offset: 0x005CE41C
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

		// Token: 0x0602AA1A RID: 174618 RVA: 0x005D0258 File Offset: 0x005CE458
		public IWuWaGoInteractStateAction? InteractConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoInteractStateAction?(default(IWuWaGoInteractStateAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BAE4 RID: 47844
		// (get) Token: 0x0602AA1B RID: 174619 RVA: 0x005D02B8 File Offset: 0x005CE4B8
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

		// Token: 0x0602AA1C RID: 174620 RVA: 0x005D02E3 File Offset: 0x005CE4E3
		public static Offset<IWuWaGoPullRod> CreateIWuWaGoPullRod(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, VectorOffset InteractConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoPullRod.AddInteractConfig(builder, InteractConfigOffset);
			IWuWaGoPullRod.AddType(builder, Type);
			return IWuWaGoPullRod.EndIWuWaGoPullRod(builder);
		}

		// Token: 0x0602AA1D RID: 174621 RVA: 0x005D0300 File Offset: 0x005CE500
		public static void StartIWuWaGoPullRod(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602AA1E RID: 174622 RVA: 0x005D0309 File Offset: 0x005CE509
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AA1F RID: 174623 RVA: 0x005D0314 File Offset: 0x005CE514
		public static void AddInteractConfig(FlatBufferBuilder builder, VectorOffset interactConfigOffset)
		{
			builder.AddOffset(1, interactConfigOffset.Value, 0);
		}

		// Token: 0x0602AA20 RID: 174624 RVA: 0x005D0324 File Offset: 0x005CE524
		public static VectorOffset CreateInteractConfigVector(FlatBufferBuilder builder, Offset<IWuWaGoInteractStateAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AA21 RID: 174625 RVA: 0x005D0364 File Offset: 0x005CE564
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoInteractStateAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA22 RID: 174626 RVA: 0x005D037E File Offset: 0x005CE57E
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoInteractStateAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA23 RID: 174627 RVA: 0x005D039C File Offset: 0x005CE59C
		public static VectorOffset CreateInteractConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoInteractStateAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AA24 RID: 174628 RVA: 0x005D03B5 File Offset: 0x005CE5B5
		public static void StartInteractConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AA25 RID: 174629 RVA: 0x005D03C0 File Offset: 0x005CE5C0
		public static Offset<IWuWaGoPullRod> EndIWuWaGoPullRod(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoPullRod>(builder.EndTable());
		}

		// Token: 0x0602AA26 RID: 174630 RVA: 0x005D03D0 File Offset: 0x005CE5D0
		public IWuWaGoPullRodT UnPack()
		{
			IWuWaGoPullRodT wuWaGoPullRodT = new IWuWaGoPullRodT();
			this.UnPackTo(wuWaGoPullRodT);
			return wuWaGoPullRodT;
		}

		// Token: 0x0602AA27 RID: 174631 RVA: 0x005D03EC File Offset: 0x005CE5EC
		public void UnPackTo(IWuWaGoPullRodT _o)
		{
			_o.Type = this.Type;
			_o.InteractConfig = new List<IWuWaGoInteractStateActionT>();
			for (int i = 0; i < this.InteractConfigLength; i++)
			{
				_o.InteractConfig.Add((this.InteractConfig(i) != null) ? this.InteractConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602AA28 RID: 174632 RVA: 0x005D0458 File Offset: 0x005CE658
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

		// Token: 0x04010054 RID: 65620
		private Table __p;
	}
}
