using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CF RID: 22991
	public struct IInteractEntityPartModelBind : IFlatbufferObject
	{
		// Token: 0x1700A717 RID: 42775
		// (get) Token: 0x06025875 RID: 153717 RVA: 0x00526078 File Offset: 0x00524278
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025876 RID: 153718 RVA: 0x00526085 File Offset: 0x00524285
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025877 RID: 153719 RVA: 0x0052608C File Offset: 0x0052428C
		public static IInteractEntityPartModelBind GetRootAsIInteractEntityPartModelBind(ByteBuffer _bb)
		{
			return IInteractEntityPartModelBind.GetRootAsIInteractEntityPartModelBind(_bb, default(IInteractEntityPartModelBind));
		}

		// Token: 0x06025878 RID: 153720 RVA: 0x005260A8 File Offset: 0x005242A8
		public static IInteractEntityPartModelBind GetRootAsIInteractEntityPartModelBind(ByteBuffer _bb, IInteractEntityPartModelBind obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025879 RID: 153721 RVA: 0x005260C5 File Offset: 0x005242C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602587A RID: 153722 RVA: 0x005260D4 File Offset: 0x005242D4
		public IInteractEntityPartModelBind __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A718 RID: 42776
		// (get) Token: 0x0602587B RID: 153723 RVA: 0x005260E4 File Offset: 0x005242E4
		public EInteractEntityPartBindType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return (EInteractEntityPartBindType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602587C RID: 153724 RVA: 0x00526120 File Offset: 0x00524320
		public IInteractEntityPartModelOptionPoint? OptionPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInteractEntityPartModelOptionPoint?(default(IInteractEntityPartModelOptionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A719 RID: 42777
		// (get) Token: 0x0602587D RID: 153725 RVA: 0x00526180 File Offset: 0x00524380
		public int OptionPointsLength
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

		// Token: 0x0602587E RID: 153726 RVA: 0x005261AB File Offset: 0x005243AB
		public static Offset<IInteractEntityPartModelBind> CreateIInteractEntityPartModelBind(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab, VectorOffset OptionPointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartModelBind.AddOptionPoints(builder, OptionPointsOffset);
			IInteractEntityPartModelBind.AddType(builder, Type);
			return IInteractEntityPartModelBind.EndIInteractEntityPartModelBind(builder);
		}

		// Token: 0x0602587F RID: 153727 RVA: 0x005261C8 File Offset: 0x005243C8
		public static void StartIInteractEntityPartModelBind(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025880 RID: 153728 RVA: 0x005261D1 File Offset: 0x005243D1
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025881 RID: 153729 RVA: 0x005261DC File Offset: 0x005243DC
		public static void AddOptionPoints(FlatBufferBuilder builder, VectorOffset optionPointsOffset)
		{
			builder.AddOffset(1, optionPointsOffset.Value, 0);
		}

		// Token: 0x06025882 RID: 153730 RVA: 0x005261EC File Offset: 0x005243EC
		public static VectorOffset CreateOptionPointsVector(FlatBufferBuilder builder, Offset<IInteractEntityPartModelOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025883 RID: 153731 RVA: 0x0052622C File Offset: 0x0052442C
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractEntityPartModelOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025884 RID: 153732 RVA: 0x00526246 File Offset: 0x00524446
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractEntityPartModelOptionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025885 RID: 153733 RVA: 0x00526264 File Offset: 0x00524464
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025886 RID: 153734 RVA: 0x0052627D File Offset: 0x0052447D
		public static void StartOptionPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025887 RID: 153735 RVA: 0x00526288 File Offset: 0x00524488
		public static Offset<IInteractEntityPartModelBind> EndIInteractEntityPartModelBind(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartModelBind>(builder.EndTable());
		}

		// Token: 0x06025888 RID: 153736 RVA: 0x00526298 File Offset: 0x00524498
		public IInteractEntityPartModelBindT UnPack()
		{
			IInteractEntityPartModelBindT interactEntityPartModelBindT = new IInteractEntityPartModelBindT();
			this.UnPackTo(interactEntityPartModelBindT);
			return interactEntityPartModelBindT;
		}

		// Token: 0x06025889 RID: 153737 RVA: 0x005262B4 File Offset: 0x005244B4
		public void UnPackTo(IInteractEntityPartModelBindT _o)
		{
			_o.Type = this.Type;
			_o.OptionPoints = new List<IInteractEntityPartModelOptionPointT>();
			for (int i = 0; i < this.OptionPointsLength; i++)
			{
				_o.OptionPoints.Add((this.OptionPoints(i) != null) ? this.OptionPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602588A RID: 153738 RVA: 0x00526320 File Offset: 0x00524520
		public static Offset<IInteractEntityPartModelBind> Pack(FlatBufferBuilder builder, IInteractEntityPartModelBindT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartModelBind>);
			}
			VectorOffset optionPointsOffset = default(VectorOffset);
			if (_o.OptionPoints != null)
			{
				Offset<IInteractEntityPartModelOptionPoint>[] array = new Offset<IInteractEntityPartModelOptionPoint>[_o.OptionPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInteractEntityPartModelOptionPoint.Pack(builder, _o.OptionPoints[i]);
				}
				optionPointsOffset = IInteractEntityPartModelBind.CreateOptionPointsVector(builder, array);
			}
			return IInteractEntityPartModelBind.CreateIInteractEntityPartModelBind(builder, _o.Type, optionPointsOffset);
		}

		// Token: 0x0400F2EF RID: 62191
		private Table __p;
	}
}
