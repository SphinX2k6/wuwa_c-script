using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C03 RID: 23555
	public struct INpcStandbyShowMode : IFlatbufferObject
	{
		// Token: 0x1700AC6A RID: 44138
		// (get) Token: 0x06026EAE RID: 159406 RVA: 0x00553D9D File Offset: 0x00551F9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026EAF RID: 159407 RVA: 0x00553DAA File Offset: 0x00551FAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026EB0 RID: 159408 RVA: 0x00553DB4 File Offset: 0x00551FB4
		public static INpcStandbyShowMode GetRootAsINpcStandbyShowMode(ByteBuffer _bb)
		{
			return INpcStandbyShowMode.GetRootAsINpcStandbyShowMode(_bb, default(INpcStandbyShowMode));
		}

		// Token: 0x06026EB1 RID: 159409 RVA: 0x00553DD0 File Offset: 0x00551FD0
		public static INpcStandbyShowMode GetRootAsINpcStandbyShowMode(ByteBuffer _bb, INpcStandbyShowMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026EB2 RID: 159410 RVA: 0x00553DED File Offset: 0x00551FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026EB3 RID: 159411 RVA: 0x00553DFC File Offset: 0x00551FFC
		public INpcStandbyShowMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC6B RID: 44139
		// (get) Token: 0x06026EB4 RID: 159412 RVA: 0x00553E0C File Offset: 0x0055200C
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

		// Token: 0x06026EB5 RID: 159413 RVA: 0x00553E48 File Offset: 0x00552048
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC6C RID: 44140
		// (get) Token: 0x06026EB6 RID: 159414 RVA: 0x00553EA8 File Offset: 0x005520A8
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

		// Token: 0x1700AC6D RID: 44141
		// (get) Token: 0x06026EB7 RID: 159415 RVA: 0x00553ED4 File Offset: 0x005520D4
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

		// Token: 0x06026EB8 RID: 159416 RVA: 0x00553F10 File Offset: 0x00552110
		public static Offset<INpcStandbyShowMode> CreateINpcStandbyShowMode(FlatBufferBuilder builder, ENpcStandbyShowMode Type = ENpcStandbyShowMode.Finite, VectorOffset LookAtConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcStandbyShowMode.AddLookAtConfigs(builder, LookAtConfigsOffset);
			INpcStandbyShowMode.AddNullMask(builder, NullMask);
			INpcStandbyShowMode.AddType(builder, Type);
			return INpcStandbyShowMode.EndINpcStandbyShowMode(builder);
		}

		// Token: 0x06026EB9 RID: 159417 RVA: 0x00553F34 File Offset: 0x00552134
		public static void StartINpcStandbyShowMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026EBA RID: 159418 RVA: 0x00553F3D File Offset: 0x0055213D
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026EBB RID: 159419 RVA: 0x00553F48 File Offset: 0x00552148
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06026EBC RID: 159420 RVA: 0x00553F58 File Offset: 0x00552158
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026EBD RID: 159421 RVA: 0x00553F98 File Offset: 0x00552198
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EBE RID: 159422 RVA: 0x00553FB2 File Offset: 0x005521B2
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026EBF RID: 159423 RVA: 0x00553FD0 File Offset: 0x005521D0
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026EC0 RID: 159424 RVA: 0x00553FE9 File Offset: 0x005521E9
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026EC1 RID: 159425 RVA: 0x00553FF4 File Offset: 0x005521F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026EC2 RID: 159426 RVA: 0x00553FFF File Offset: 0x005521FF
		public static Offset<INpcStandbyShowMode> EndINpcStandbyShowMode(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowMode>(builder.EndTable());
		}

		// Token: 0x06026EC3 RID: 159427 RVA: 0x0055400C File Offset: 0x0055220C
		public INpcStandbyShowModeT UnPack()
		{
			INpcStandbyShowModeT npcStandbyShowModeT = new INpcStandbyShowModeT();
			this.UnPackTo(npcStandbyShowModeT);
			return npcStandbyShowModeT;
		}

		// Token: 0x06026EC4 RID: 159428 RVA: 0x00554028 File Offset: 0x00552228
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

		// Token: 0x06026EC5 RID: 159429 RVA: 0x005540A0 File Offset: 0x005522A0
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

		// Token: 0x0400F686 RID: 63110
		private Table __p;
	}
}
