using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DEE RID: 24046
	public struct IRandomInteract : IFlatbufferObject
	{
		// Token: 0x1700B138 RID: 45368
		// (get) Token: 0x0602821E RID: 164382 RVA: 0x0057D21B File Offset: 0x0057B41B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602821F RID: 164383 RVA: 0x0057D228 File Offset: 0x0057B428
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028220 RID: 164384 RVA: 0x0057D230 File Offset: 0x0057B430
		public static IRandomInteract GetRootAsIRandomInteract(ByteBuffer _bb)
		{
			return IRandomInteract.GetRootAsIRandomInteract(_bb, default(IRandomInteract));
		}

		// Token: 0x06028221 RID: 164385 RVA: 0x0057D24C File Offset: 0x0057B44C
		public static IRandomInteract GetRootAsIRandomInteract(ByteBuffer _bb, IRandomInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028222 RID: 164386 RVA: 0x0057D269 File Offset: 0x0057B469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028223 RID: 164387 RVA: 0x0057D278 File Offset: 0x0057B478
		public IRandomInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B139 RID: 45369
		// (get) Token: 0x06028224 RID: 164388 RVA: 0x0057D288 File Offset: 0x0057B488
		public int RandomCount
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028225 RID: 164389 RVA: 0x0057D2C4 File Offset: 0x0057B4C4
		public IRandomInteractOption? Options(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRandomInteractOption?(default(IRandomInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B13A RID: 45370
		// (get) Token: 0x06028226 RID: 164390 RVA: 0x0057D324 File Offset: 0x0057B524
		public int OptionsLength
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

		// Token: 0x06028227 RID: 164391 RVA: 0x0057D34F File Offset: 0x0057B54F
		public static Offset<IRandomInteract> CreateIRandomInteract(FlatBufferBuilder builder, int RandomCount = 0, VectorOffset OptionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomInteract.AddOptions(builder, OptionsOffset);
			IRandomInteract.AddRandomCount(builder, RandomCount);
			return IRandomInteract.EndIRandomInteract(builder);
		}

		// Token: 0x06028228 RID: 164392 RVA: 0x0057D36C File Offset: 0x0057B56C
		public static void StartIRandomInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x0057D375 File Offset: 0x0057B575
		public static void AddRandomCount(FlatBufferBuilder builder, int randomCount)
		{
			builder.AddInt(0, randomCount, 0);
		}

		// Token: 0x0602822A RID: 164394 RVA: 0x0057D380 File Offset: 0x0057B580
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(1, optionsOffset.Value, 0);
		}

		// Token: 0x0602822B RID: 164395 RVA: 0x0057D390 File Offset: 0x0057B590
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<IRandomInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x0057D3D0 File Offset: 0x0057B5D0
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<IRandomInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRandomInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x0057D3EA File Offset: 0x0057B5EA
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRandomInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRandomInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x0057D408 File Offset: 0x0057B608
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRandomInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602822F RID: 164399 RVA: 0x0057D421 File Offset: 0x0057B621
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x0057D42C File Offset: 0x0057B62C
		public static Offset<IRandomInteract> EndIRandomInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRandomInteract>(builder.EndTable());
		}

		// Token: 0x06028231 RID: 164401 RVA: 0x0057D43C File Offset: 0x0057B63C
		public IRandomInteractT UnPack()
		{
			IRandomInteractT randomInteractT = new IRandomInteractT();
			this.UnPackTo(randomInteractT);
			return randomInteractT;
		}

		// Token: 0x06028232 RID: 164402 RVA: 0x0057D458 File Offset: 0x0057B658
		public void UnPackTo(IRandomInteractT _o)
		{
			_o.RandomCount = this.RandomCount;
			_o.Options = new List<IRandomInteractOptionT>();
			for (int i = 0; i < this.OptionsLength; i++)
			{
				_o.Options.Add((this.Options(i) != null) ? this.Options(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028233 RID: 164403 RVA: 0x0057D4C4 File Offset: 0x0057B6C4
		public static Offset<IRandomInteract> Pack(FlatBufferBuilder builder, IRandomInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomInteract>);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<IRandomInteractOption>[] array = new Offset<IRandomInteractOption>[_o.Options.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRandomInteractOption.Pack(builder, _o.Options[i]);
				}
				optionsOffset = IRandomInteract.CreateOptionsVector(builder, array);
			}
			return IRandomInteract.CreateIRandomInteract(builder, _o.RandomCount, optionsOffset);
		}

		// Token: 0x0400F9C4 RID: 63940
		private Table __p;
	}
}
