using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFA RID: 23546
	public struct INpcStandbyShowFinitely : IFlatbufferObject
	{
		// Token: 0x1700AC41 RID: 44097
		// (get) Token: 0x06026E22 RID: 159266 RVA: 0x005528E5 File Offset: 0x00550AE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E23 RID: 159267 RVA: 0x005528F2 File Offset: 0x00550AF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E24 RID: 159268 RVA: 0x005528FC File Offset: 0x00550AFC
		public static INpcStandbyShowFinitely GetRootAsINpcStandbyShowFinitely(ByteBuffer _bb)
		{
			return INpcStandbyShowFinitely.GetRootAsINpcStandbyShowFinitely(_bb, default(INpcStandbyShowFinitely));
		}

		// Token: 0x06026E25 RID: 159269 RVA: 0x00552918 File Offset: 0x00550B18
		public static INpcStandbyShowFinitely GetRootAsINpcStandbyShowFinitely(ByteBuffer _bb, INpcStandbyShowFinitely obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E26 RID: 159270 RVA: 0x00552935 File Offset: 0x00550B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E27 RID: 159271 RVA: 0x00552944 File Offset: 0x00550B44
		public INpcStandbyShowFinitely __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC42 RID: 44098
		// (get) Token: 0x06026E28 RID: 159272 RVA: 0x00552954 File Offset: 0x00550B54
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

		// Token: 0x06026E29 RID: 159273 RVA: 0x00552990 File Offset: 0x00550B90
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC43 RID: 44099
		// (get) Token: 0x06026E2A RID: 159274 RVA: 0x005529F0 File Offset: 0x00550BF0
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

		// Token: 0x1700AC44 RID: 44100
		// (get) Token: 0x06026E2B RID: 159275 RVA: 0x00552A1C File Offset: 0x00550C1C
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

		// Token: 0x06026E2C RID: 159276 RVA: 0x00552A58 File Offset: 0x00550C58
		public INpcStandbyShowFinitelyInfo? Montages(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo?(default(INpcStandbyShowFinitelyInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC45 RID: 44101
		// (get) Token: 0x06026E2D RID: 159277 RVA: 0x00552ABC File Offset: 0x00550CBC
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

		// Token: 0x1700AC46 RID: 44102
		// (get) Token: 0x06026E2E RID: 159278 RVA: 0x00552AE8 File Offset: 0x00550CE8
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

		// Token: 0x06026E2F RID: 159279 RVA: 0x00552B25 File Offset: 0x00550D25
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

		// Token: 0x06026E30 RID: 159280 RVA: 0x00552B59 File Offset: 0x00550D59
		public static void StartINpcStandbyShowFinitely(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026E31 RID: 159281 RVA: 0x00552B62 File Offset: 0x00550D62
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E32 RID: 159282 RVA: 0x00552B6D File Offset: 0x00550D6D
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06026E33 RID: 159283 RVA: 0x00552B80 File Offset: 0x00550D80
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026E34 RID: 159284 RVA: 0x00552BC0 File Offset: 0x00550DC0
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E35 RID: 159285 RVA: 0x00552BDA File Offset: 0x00550DDA
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E36 RID: 159286 RVA: 0x00552BF8 File Offset: 0x00550DF8
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026E37 RID: 159287 RVA: 0x00552C11 File Offset: 0x00550E11
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026E38 RID: 159288 RVA: 0x00552C1C File Offset: 0x00550E1C
		public static void AddPlayMode(FlatBufferBuilder builder, ENpcStandbyShowFinitelyPlayMode playMode)
		{
			builder.AddByte(2, (byte)playMode, 0);
		}

		// Token: 0x06026E39 RID: 159289 RVA: 0x00552C27 File Offset: 0x00550E27
		public static void AddMontages(FlatBufferBuilder builder, VectorOffset montagesOffset)
		{
			builder.AddOffset(3, montagesOffset.Value, 0);
		}

		// Token: 0x06026E3A RID: 159290 RVA: 0x00552C38 File Offset: 0x00550E38
		public static VectorOffset CreateMontagesVector(FlatBufferBuilder builder, Offset<INpcStandbyShowFinitelyInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026E3B RID: 159291 RVA: 0x00552C78 File Offset: 0x00550E78
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, Offset<INpcStandbyShowFinitelyInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E3C RID: 159292 RVA: 0x00552C92 File Offset: 0x00550E92
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcStandbyShowFinitelyInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E3D RID: 159293 RVA: 0x00552CB0 File Offset: 0x00550EB0
		public static VectorOffset CreateMontagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcStandbyShowFinitelyInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026E3E RID: 159294 RVA: 0x00552CC9 File Offset: 0x00550EC9
		public static void StartMontagesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026E3F RID: 159295 RVA: 0x00552CD4 File Offset: 0x00550ED4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026E40 RID: 159296 RVA: 0x00552CDF File Offset: 0x00550EDF
		public static Offset<INpcStandbyShowFinitely> EndINpcStandbyShowFinitely(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowFinitely>(builder.EndTable());
		}

		// Token: 0x06026E41 RID: 159297 RVA: 0x00552CEC File Offset: 0x00550EEC
		public INpcStandbyShowFinitelyT UnPack()
		{
			INpcStandbyShowFinitelyT npcStandbyShowFinitelyT = new INpcStandbyShowFinitelyT();
			this.UnPackTo(npcStandbyShowFinitelyT);
			return npcStandbyShowFinitelyT;
		}

		// Token: 0x06026E42 RID: 159298 RVA: 0x00552D08 File Offset: 0x00550F08
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

		// Token: 0x06026E43 RID: 159299 RVA: 0x00552DE0 File Offset: 0x00550FE0
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

		// Token: 0x0400F670 RID: 63088
		private Table __p;
	}
}
