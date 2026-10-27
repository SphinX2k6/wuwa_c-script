using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005659 RID: 22105
	public struct INpcStandbyShowFinitely : IFlatbufferObject
	{
		// Token: 0x1700A3B2 RID: 41906
		// (get) Token: 0x06024BE9 RID: 150505 RVA: 0x00511D49 File Offset: 0x0050FF49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BEA RID: 150506 RVA: 0x00511D56 File Offset: 0x0050FF56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BEB RID: 150507 RVA: 0x00511D60 File Offset: 0x0050FF60
		public static INpcStandbyShowFinitely GetRootAsINpcStandbyShowFinitely(ByteBuffer _bb)
		{
			return INpcStandbyShowFinitely.GetRootAsINpcStandbyShowFinitely(_bb, default(INpcStandbyShowFinitely));
		}

		// Token: 0x06024BEC RID: 150508 RVA: 0x00511D7C File Offset: 0x0050FF7C
		public static INpcStandbyShowFinitely GetRootAsINpcStandbyShowFinitely(ByteBuffer _bb, INpcStandbyShowFinitely obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BED RID: 150509 RVA: 0x00511D99 File Offset: 0x0050FF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BEE RID: 150510 RVA: 0x00511DA8 File Offset: 0x0050FFA8
		public INpcStandbyShowFinitely __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3B3 RID: 41907
		// (get) Token: 0x06024BEF RID: 150511 RVA: 0x00511DB8 File Offset: 0x0050FFB8
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

		// Token: 0x06024BF0 RID: 150512 RVA: 0x00511DF4 File Offset: 0x0050FFF4
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3B4 RID: 41908
		// (get) Token: 0x06024BF1 RID: 150513 RVA: 0x00511E54 File Offset: 0x00510054
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

		// Token: 0x1700A3B5 RID: 41909
		// (get) Token: 0x06024BF2 RID: 150514 RVA: 0x00511E80 File Offset: 0x00510080
		public ENpcStandbyShowFinitelyPlayMode PlayMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ENpcStandbyShowFinitelyPlayMode.Randomly;
				}
				return (ENpcStandbyShowFinitelyPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BF3 RID: 150515 RVA: 0x00511EBC File Offset: 0x005100BC
		public INpcStandbyShowFinitelyInfo? Montages(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo?(default(INpcStandbyShowFinitelyInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3B6 RID: 41910
		// (get) Token: 0x06024BF4 RID: 150516 RVA: 0x00511F20 File Offset: 0x00510120
		public int MontagesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A3B7 RID: 41911
		// (get) Token: 0x06024BF5 RID: 150517 RVA: 0x00511F4C File Offset: 0x0051014C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BF6 RID: 150518 RVA: 0x00511F89 File Offset: 0x00510189
		public static Offset<INpcStandbyShowFinitely> CreateINpcStandbyShowFinitely(FlatBufferBuilder builder, ENpcStandbyShowMode Type = ENpcStandbyShowMode.Finite, VectorOffset LookAtConfigsOffset = default(VectorOffset), ENpcStandbyShowFinitelyPlayMode PlayMode = ENpcStandbyShowFinitelyPlayMode.Randomly, VectorOffset MontagesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			INpcStandbyShowFinitely.AddMontages(builder, MontagesOffset);
			INpcStandbyShowFinitely.AddLookAtConfigs(builder, LookAtConfigsOffset);
			INpcStandbyShowFinitely.AddNullMask(builder, NullMask);
			INpcStandbyShowFinitely.AddPlayMode(builder, PlayMode);
			INpcStandbyShowFinitely.AddType(builder, Type);
			return INpcStandbyShowFinitely.EndINpcStandbyShowFinitely(builder);
		}

		// Token: 0x06024BF7 RID: 150519 RVA: 0x00511FBD File Offset: 0x005101BD
		public static void StartINpcStandbyShowFinitely(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024BF8 RID: 150520 RVA: 0x00511FC6 File Offset: 0x005101C6
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024BF9 RID: 150521 RVA: 0x00511FD1 File Offset: 0x005101D1
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06024BFA RID: 150522 RVA: 0x00511FE4 File Offset: 0x005101E4
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024BFB RID: 150523 RVA: 0x00512024 File Offset: 0x00510224
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024BFC RID: 150524 RVA: 0x0051203E File Offset: 0x0051023E
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024BFD RID: 150525 RVA: 0x0051205C File Offset: 0x0051025C
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024BFE RID: 150526 RVA: 0x00512075 File Offset: 0x00510275
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024BFF RID: 150527 RVA: 0x00512080 File Offset: 0x00510280
		public static void AddPlayMode(FlatBufferBuilder builder, ENpcStandbyShowFinitelyPlayMode playMode)
		{
			builder.AddByte(2, (byte)playMode, 0);
		}

		// Token: 0x06024C00 RID: 150528 RVA: 0x0051208B File Offset: 0x0051028B
		public static void AddMontages(FlatBufferBuilder builder, VectorOffset montagesOffset)
		{
			builder.AddOffset(3, montagesOffset.Value, 0);
		}

		// Token: 0x06024C01 RID: 150529 RVA: 0x0051209C File Offset: 0x0051029C
		public static VectorOffset CreateMontagesVector(FlatBufferBuilder builder, Offset<INpcStandbyShowFinitelyInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024C02 RID: 150530 RVA: 0x005120DC File Offset: 0x005102DC
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, Offset<INpcStandbyShowFinitelyInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C03 RID: 150531 RVA: 0x005120F6 File Offset: 0x005102F6
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcStandbyShowFinitelyInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C04 RID: 150532 RVA: 0x00512114 File Offset: 0x00510314
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024C05 RID: 150533 RVA: 0x0051212D File Offset: 0x0051032D
		public static void StartMontagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024C06 RID: 150534 RVA: 0x00512138 File Offset: 0x00510338
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024C07 RID: 150535 RVA: 0x00512143 File Offset: 0x00510343
		public static Offset<INpcStandbyShowFinitely> EndINpcStandbyShowFinitely(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowFinitely>(builder.EndTable());
		}

		// Token: 0x06024C08 RID: 150536 RVA: 0x00512150 File Offset: 0x00510350
		public INpcStandbyShowFinitelyT UnPack()
		{
			INpcStandbyShowFinitelyT npcStandbyShowFinitelyT = new INpcStandbyShowFinitelyT();
			this.UnPackTo(npcStandbyShowFinitelyT);
			return npcStandbyShowFinitelyT;
		}

		// Token: 0x06024C09 RID: 150537 RVA: 0x0051216C File Offset: 0x0051036C
		public void UnPackTo(INpcStandbyShowFinitelyT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
			_o.PlayMode = this.PlayMode;
			_o.Montages = new List<INpcStandbyShowFinitelyInfoT>();
			for (int j = 0; j < this.MontagesLength; j++)
			{
				_o.Montages.Add((this.Montages(j) != null) ? this.Montages(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024C0A RID: 150538 RVA: 0x00512244 File Offset: 0x00510444
		public static Offset<INpcStandbyShowFinitely> Pack(FlatBufferBuilder builder, INpcStandbyShowFinitelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcStandbyShowFinitely>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = INpcStandbyShowFinitely.CreateLookAtConfigsVector(builder, array);
			}
			VectorOffset montagesOffset = default(VectorOffset);
			if (_o.Montages != null)
			{
				Offset<INpcStandbyShowFinitelyInfo>[] array2 = new Offset<INpcStandbyShowFinitelyInfo>[_o.Montages.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = INpcStandbyShowFinitelyInfo.Pack(builder, _o.Montages[j]);
				}
				montagesOffset = INpcStandbyShowFinitely.CreateMontagesVector(builder, array2);
			}
			return INpcStandbyShowFinitely.CreateINpcStandbyShowFinitely(builder, _o.Type, lookAtConfigsOffset, _o.PlayMode, montagesOffset, _o.NullMask);
		}

		// Token: 0x0400EA07 RID: 59911
		private Table __p;
	}
}
