using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F80 RID: 16256
	public struct IPhotographCondition : IFlatbufferObject
	{
		// Token: 0x17007174 RID: 29044
		// (get) Token: 0x0601733C RID: 95036 RVA: 0x00358FAA File Offset: 0x003571AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601733D RID: 95037 RVA: 0x00358FB7 File Offset: 0x003571B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601733E RID: 95038 RVA: 0x00358FC0 File Offset: 0x003571C0
		public static IPhotographCondition GetRootAsIPhotographCondition(ByteBuffer _bb)
		{
			return IPhotographCondition.GetRootAsIPhotographCondition(_bb, default(IPhotographCondition));
		}

		// Token: 0x0601733F RID: 95039 RVA: 0x00358FDC File Offset: 0x003571DC
		public static IPhotographCondition GetRootAsIPhotographCondition(ByteBuffer _bb, IPhotographCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017340 RID: 95040 RVA: 0x00358FF9 File Offset: 0x003571F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x00359008 File Offset: 0x00357208
		public IPhotographCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007175 RID: 29045
		// (get) Token: 0x06017342 RID: 95042 RVA: 0x00359018 File Offset: 0x00357218
		public string TidTip
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017343 RID: 95043 RVA: 0x0035904F File Offset: 0x0035724F
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017344 RID: 95044 RVA: 0x0035905E File Offset: 0x0035725E
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007176 RID: 29046
		// (get) Token: 0x06017345 RID: 95045 RVA: 0x0035906C File Offset: 0x0035726C
		public TPhotographTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPhotographTarget.NONE;
				}
				return (TPhotographTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017346 RID: 95046 RVA: 0x003590A8 File Offset: 0x003572A8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017347 RID: 95047 RVA: 0x003590EC File Offset: 0x003572EC
		public IPhotographTargetPlayer TargetAsIPhotographTargetPlayer()
		{
			return this.Target<IPhotographTargetPlayer>().Value;
		}

		// Token: 0x06017348 RID: 95048 RVA: 0x00359108 File Offset: 0x00357308
		public IPhotographTargetRolesOnScene TargetAsIPhotographTargetRolesOnScene()
		{
			return this.Target<IPhotographTargetRolesOnScene>().Value;
		}

		// Token: 0x06017349 RID: 95049 RVA: 0x00359124 File Offset: 0x00357324
		public TPhotographSubTarget SubTargetsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPhotographSubTarget.NONE;
			}
			return (TPhotographSubTarget)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007177 RID: 29047
		// (get) Token: 0x0601734A RID: 95050 RVA: 0x00359164 File Offset: 0x00357364
		public int SubTargetsTypeLength
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

		// Token: 0x0601734B RID: 95051 RVA: 0x00359190 File Offset: 0x00357390
		public Span<TPhotographSubTarget> GetSubTargetsTypeBytes()
		{
			return this.__p.__vector_as_span<TPhotographSubTarget>(10, 1);
		}

		// Token: 0x0601734C RID: 95052 RVA: 0x003591A0 File Offset: 0x003573A0
		public TPhotographSubTarget[] GetSubTargetsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPhotographSubTarget[] array = new TPhotographSubTarget[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPhotographSubTarget)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601734D RID: 95053 RVA: 0x0035920C File Offset: 0x0035740C
		public TTable? SubTargets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007178 RID: 29048
		// (get) Token: 0x0601734E RID: 95054 RVA: 0x00359254 File Offset: 0x00357454
		public int SubTargetsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007179 RID: 29049
		// (get) Token: 0x0601734F RID: 95055 RVA: 0x00359280 File Offset: 0x00357480
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017350 RID: 95056 RVA: 0x003592BD File Offset: 0x003574BD
		public static Offset<IPhotographCondition> CreateIPhotographCondition(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), TPhotographTarget Target_type = TPhotographTarget.NONE, int TargetOffset = 0, VectorOffset SubTargets_typeOffset = default(VectorOffset), VectorOffset SubTargetsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IPhotographCondition.AddSubTargets(builder, SubTargetsOffset);
			IPhotographCondition.AddSubTargetsType(builder, SubTargets_typeOffset);
			IPhotographCondition.AddTarget(builder, TargetOffset);
			IPhotographCondition.AddTidTip(builder, TidTipOffset);
			IPhotographCondition.AddNullMask(builder, NullMask);
			IPhotographCondition.AddTargetType(builder, Target_type);
			return IPhotographCondition.EndIPhotographCondition(builder);
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x003592F9 File Offset: 0x003574F9
		public static void StartIPhotographCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017352 RID: 95058 RVA: 0x00359302 File Offset: 0x00357502
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x06017353 RID: 95059 RVA: 0x00359312 File Offset: 0x00357512
		public static void AddTargetType(FlatBufferBuilder builder, TPhotographTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06017354 RID: 95060 RVA: 0x0035931D File Offset: 0x0035751D
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06017355 RID: 95061 RVA: 0x00359328 File Offset: 0x00357528
		public static void AddSubTargetsType(FlatBufferBuilder builder, VectorOffset subTargetsTypeOffset)
		{
			builder.AddOffset(3, subTargetsTypeOffset.Value, 0);
		}

		// Token: 0x06017356 RID: 95062 RVA: 0x00359338 File Offset: 0x00357538
		public static VectorOffset CreateSubTargetsTypeVector(FlatBufferBuilder builder, TPhotographSubTarget[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017357 RID: 95063 RVA: 0x0035936F File Offset: 0x0035756F
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, TPhotographSubTarget[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPhotographSubTarget>(data);
			return builder.EndVector();
		}

		// Token: 0x06017358 RID: 95064 RVA: 0x00359389 File Offset: 0x00357589
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPhotographSubTarget> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPhotographSubTarget>(data);
			return builder.EndVector();
		}

		// Token: 0x06017359 RID: 95065 RVA: 0x003593A7 File Offset: 0x003575A7
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPhotographSubTarget>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601735A RID: 95066 RVA: 0x003593C0 File Offset: 0x003575C0
		public static void StartSubTargetsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601735B RID: 95067 RVA: 0x003593CB File Offset: 0x003575CB
		public static void AddSubTargets(FlatBufferBuilder builder, VectorOffset subTargetsOffset)
		{
			builder.AddOffset(4, subTargetsOffset.Value, 0);
		}

		// Token: 0x0601735C RID: 95068 RVA: 0x003593DC File Offset: 0x003575DC
		public static VectorOffset CreateSubTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x00359413 File Offset: 0x00357613
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601735E RID: 95070 RVA: 0x0035942D File Offset: 0x0035762D
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601735F RID: 95071 RVA: 0x0035944B File Offset: 0x0035764B
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017360 RID: 95072 RVA: 0x00359464 File Offset: 0x00357664
		public static void StartSubTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017361 RID: 95073 RVA: 0x0035946F File Offset: 0x0035766F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017362 RID: 95074 RVA: 0x0035947A File Offset: 0x0035767A
		public static Offset<IPhotographCondition> EndIPhotographCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCondition>(builder.EndTable());
		}

		// Token: 0x06017363 RID: 95075 RVA: 0x00359488 File Offset: 0x00357688
		public IPhotographConditionT UnPack()
		{
			IPhotographConditionT photographConditionT = new IPhotographConditionT();
			this.UnPackTo(photographConditionT);
			return photographConditionT;
		}

		// Token: 0x06017364 RID: 95076 RVA: 0x003594A4 File Offset: 0x003576A4
		public void UnPackTo(IPhotographConditionT _o)
		{
			_o.TidTip = this.TidTip;
			_o.Target = new TPhotographTargetUnion();
			_o.Target.Type = this.TargetType;
			TPhotographTarget targetType = this.TargetType;
			if (targetType != TPhotographTarget.IPhotographTargetPlayer)
			{
				if (targetType == TPhotographTarget.IPhotographTargetRolesOnScene)
				{
					_o.Target.Value = ((this.Target<IPhotographTargetRolesOnScene>() != null) ? this.Target<IPhotographTargetRolesOnScene>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IPhotographTargetPlayer>() != null) ? this.Target<IPhotographTargetPlayer>().Value.UnPack() : null);
			}
			_o.SubTargets = new List<TPhotographSubTargetUnion>();
			for (int i = 0; i < this.SubTargetsLength; i++)
			{
				TPhotographSubTargetUnion tphotographSubTargetUnion = new TPhotographSubTargetUnion();
				tphotographSubTargetUnion.Type = this.SubTargetsType(i);
				TPhotographSubTarget tphotographSubTarget = this.SubTargetsType(i);
				if (tphotographSubTarget != TPhotographSubTarget.IPhotographSubTargetAnyRole)
				{
					if (tphotographSubTarget == TPhotographSubTarget.IPhotographSubTargetSpecificRole)
					{
						tphotographSubTargetUnion.Value = ((this.SubTargets<IPhotographSubTargetSpecificRole>(i) != null) ? this.SubTargets<IPhotographSubTargetSpecificRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tphotographSubTargetUnion.Value = ((this.SubTargets<IPhotographSubTargetAnyRole>(i) != null) ? this.SubTargets<IPhotographSubTargetAnyRole>(i).Value.UnPack() : null);
				}
				_o.SubTargets.Add(tphotographSubTargetUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017365 RID: 95077 RVA: 0x00359630 File Offset: 0x00357830
		public static Offset<IPhotographCondition> Pack(FlatBufferBuilder builder, IPhotographConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCondition>);
			}
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			TPhotographTarget target_type = (_o.Target == null) ? TPhotographTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TPhotographTargetUnion.Pack(builder, _o.Target);
			VectorOffset subTargets_typeOffset = default(VectorOffset);
			if (_o.SubTargets != null)
			{
				TPhotographSubTarget[] array = new TPhotographSubTarget[_o.SubTargets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.SubTargets[i].Type;
				}
				subTargets_typeOffset = IPhotographCondition.CreateSubTargetsTypeVector(builder, array);
			}
			VectorOffset subTargetsOffset = default(VectorOffset);
			if (_o.SubTargets != null)
			{
				int[] array2 = new int[_o.SubTargets.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPhotographSubTargetUnion.Pack(builder, _o.SubTargets[j]);
				}
				subTargetsOffset = IPhotographCondition.CreateSubTargetsVector(builder, array2);
			}
			return IPhotographCondition.CreateIPhotographCondition(builder, tidTipOffset, target_type, targetOffset, subTargets_typeOffset, subTargetsOffset, _o.NullMask);
		}

		// Token: 0x0400B9D5 RID: 47573
		private Table __p;
	}
}
