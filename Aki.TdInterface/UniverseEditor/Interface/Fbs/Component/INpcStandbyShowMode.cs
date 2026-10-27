using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005662 RID: 22114
	public struct INpcStandbyShowMode : IFlatbufferObject
	{
		// Token: 0x1700A3DB RID: 41947
		// (get) Token: 0x06024C75 RID: 150645 RVA: 0x00513201 File Offset: 0x00511401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C76 RID: 150646 RVA: 0x0051320E File Offset: 0x0051140E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C77 RID: 150647 RVA: 0x00513218 File Offset: 0x00511418
		public static INpcStandbyShowMode GetRootAsINpcStandbyShowMode(ByteBuffer _bb)
		{
			return INpcStandbyShowMode.GetRootAsINpcStandbyShowMode(_bb, default(INpcStandbyShowMode));
		}

		// Token: 0x06024C78 RID: 150648 RVA: 0x00513234 File Offset: 0x00511434
		public static INpcStandbyShowMode GetRootAsINpcStandbyShowMode(ByteBuffer _bb, INpcStandbyShowMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C79 RID: 150649 RVA: 0x00513251 File Offset: 0x00511451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C7A RID: 150650 RVA: 0x00513260 File Offset: 0x00511460
		public INpcStandbyShowMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3DC RID: 41948
		// (get) Token: 0x06024C7B RID: 150651 RVA: 0x00513270 File Offset: 0x00511470
		public ENpcStandbyShowMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcStandbyShowMode.Finite;
				}
				return (ENpcStandbyShowMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024C7C RID: 150652 RVA: 0x005132AC File Offset: 0x005114AC
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3DD RID: 41949
		// (get) Token: 0x06024C7D RID: 150653 RVA: 0x0051330C File Offset: 0x0051150C
		public int LookAtConfigsLength
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

		// Token: 0x1700A3DE RID: 41950
		// (get) Token: 0x06024C7E RID: 150654 RVA: 0x00513338 File Offset: 0x00511538
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024C7F RID: 150655 RVA: 0x00513374 File Offset: 0x00511574
		public static Offset<INpcStandbyShowMode> CreateINpcStandbyShowMode(FlatBufferBuilder builder, ENpcStandbyShowMode Type = ENpcStandbyShowMode.Finite, VectorOffset LookAtConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcStandbyShowMode.AddLookAtConfigs(builder, LookAtConfigsOffset);
			INpcStandbyShowMode.AddNullMask(builder, NullMask);
			INpcStandbyShowMode.AddType(builder, Type);
			return INpcStandbyShowMode.EndINpcStandbyShowMode(builder);
		}

		// Token: 0x06024C80 RID: 150656 RVA: 0x00513398 File Offset: 0x00511598
		public static void StartINpcStandbyShowMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024C81 RID: 150657 RVA: 0x005133A1 File Offset: 0x005115A1
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024C82 RID: 150658 RVA: 0x005133AC File Offset: 0x005115AC
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06024C83 RID: 150659 RVA: 0x005133BC File Offset: 0x005115BC
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024C84 RID: 150660 RVA: 0x005133FC File Offset: 0x005115FC
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C85 RID: 150661 RVA: 0x00513416 File Offset: 0x00511616
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C86 RID: 150662 RVA: 0x00513434 File Offset: 0x00511634
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024C87 RID: 150663 RVA: 0x0051344D File Offset: 0x0051164D
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024C88 RID: 150664 RVA: 0x00513458 File Offset: 0x00511658
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024C89 RID: 150665 RVA: 0x00513463 File Offset: 0x00511663
		public static Offset<INpcStandbyShowMode> EndINpcStandbyShowMode(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowMode>(builder.EndTable());
		}

		// Token: 0x06024C8A RID: 150666 RVA: 0x00513470 File Offset: 0x00511670
		public INpcStandbyShowModeT UnPack()
		{
			INpcStandbyShowModeT npcStandbyShowModeT = new INpcStandbyShowModeT();
			this.UnPackTo(npcStandbyShowModeT);
			return npcStandbyShowModeT;
		}

		// Token: 0x06024C8B RID: 150667 RVA: 0x0051348C File Offset: 0x0051168C
		public void UnPackTo(INpcStandbyShowModeT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024C8C RID: 150668 RVA: 0x00513504 File Offset: 0x00511704
		public static Offset<INpcStandbyShowMode> Pack(FlatBufferBuilder builder, INpcStandbyShowModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcStandbyShowMode>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = INpcStandbyShowMode.CreateLookAtConfigsVector(builder, array);
			}
			return INpcStandbyShowMode.CreateINpcStandbyShowMode(builder, _o.Type, lookAtConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400EA1D RID: 59933
		private Table __p;
	}
}
