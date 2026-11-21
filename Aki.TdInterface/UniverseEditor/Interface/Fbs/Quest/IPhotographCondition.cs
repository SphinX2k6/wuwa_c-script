using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C1 RID: 17345
	public struct IPhotographCondition : IFlatbufferObject
	{
		// Token: 0x17007772 RID: 30578
		// (get) Token: 0x060189CB RID: 100811 RVA: 0x00382BC2 File Offset: 0x00380DC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189CC RID: 100812 RVA: 0x00382BCF File Offset: 0x00380DCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189CD RID: 100813 RVA: 0x00382BD8 File Offset: 0x00380DD8
		public static IPhotographCondition GetRootAsIPhotographCondition(ByteBuffer _bb)
		{
			return IPhotographCondition.GetRootAsIPhotographCondition(_bb, default(IPhotographCondition));
		}

		// Token: 0x060189CE RID: 100814 RVA: 0x00382BF4 File Offset: 0x00380DF4
		public static IPhotographCondition GetRootAsIPhotographCondition(ByteBuffer _bb, IPhotographCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x00382C11 File Offset: 0x00380E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060189D0 RID: 100816 RVA: 0x00382C20 File Offset: 0x00380E20
		public IPhotographCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007773 RID: 30579
		// (get) Token: 0x060189D1 RID: 100817 RVA: 0x00382C30 File Offset: 0x00380E30
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

		// Token: 0x060189D2 RID: 100818 RVA: 0x00382C67 File Offset: 0x00380E67
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060189D3 RID: 100819 RVA: 0x00382C76 File Offset: 0x00380E76
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007774 RID: 30580
		// (get) Token: 0x060189D4 RID: 100820 RVA: 0x00382C84 File Offset: 0x00380E84
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

		// Token: 0x060189D5 RID: 100821 RVA: 0x00382CC0 File Offset: 0x00380EC0
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060189D6 RID: 100822 RVA: 0x00382D04 File Offset: 0x00380F04
		public IPhotographTargetPlayer TargetAsIPhotographTargetPlayer()
		{
			return this.Target<IPhotographTargetPlayer>().Value;
		}

		// Token: 0x060189D7 RID: 100823 RVA: 0x00382D20 File Offset: 0x00380F20
		public IPhotographTargetRolesOnScene TargetAsIPhotographTargetRolesOnScene()
		{
			return this.Target<IPhotographTargetRolesOnScene>().Value;
		}

		// Token: 0x060189D8 RID: 100824 RVA: 0x00382D3C File Offset: 0x00380F3C
		public TPhotographSubTarget SubTargetsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPhotographSubTarget.NONE;
			}
			return (TPhotographSubTarget)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007775 RID: 30581
		// (get) Token: 0x060189D9 RID: 100825 RVA: 0x00382D7C File Offset: 0x00380F7C
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

		// Token: 0x060189DA RID: 100826 RVA: 0x00382DA8 File Offset: 0x00380FA8
		public Span<TPhotographSubTarget> GetSubTargetsTypeBytes()
		{
			return this.__p.__vector_as_span<TPhotographSubTarget>(10, 1);
		}

		// Token: 0x060189DB RID: 100827 RVA: 0x00382DB8 File Offset: 0x00380FB8
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

		// Token: 0x060189DC RID: 100828 RVA: 0x00382E24 File Offset: 0x00381024
		public TTable? SubTargets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007776 RID: 30582
		// (get) Token: 0x060189DD RID: 100829 RVA: 0x00382E6C File Offset: 0x0038106C
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

		// Token: 0x17007777 RID: 30583
		// (get) Token: 0x060189DE RID: 100830 RVA: 0x00382E98 File Offset: 0x00381098
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

		// Token: 0x060189DF RID: 100831 RVA: 0x00382ED5 File Offset: 0x003810D5
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

		// Token: 0x060189E0 RID: 100832 RVA: 0x00382F11 File Offset: 0x00381111
		public static void StartIPhotographCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x00382F1A File Offset: 0x0038111A
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x00382F2A File Offset: 0x0038112A
		public static void AddTargetType(FlatBufferBuilder builder, TPhotographTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x060189E3 RID: 100835 RVA: 0x00382F35 File Offset: 0x00381135
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x060189E4 RID: 100836 RVA: 0x00382F40 File Offset: 0x00381140
		public static void AddSubTargetsType(FlatBufferBuilder builder, VectorOffset subTargetsTypeOffset)
		{
			builder.AddOffset(3, subTargetsTypeOffset.Value, 0);
		}

		// Token: 0x060189E5 RID: 100837 RVA: 0x00382F50 File Offset: 0x00381150
		public static VectorOffset CreateSubTargetsTypeVector(FlatBufferBuilder builder, TPhotographSubTarget[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x00382F87 File Offset: 0x00381187
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, TPhotographSubTarget[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPhotographSubTarget>(data);
			return builder.EndVector();
		}

		// Token: 0x060189E7 RID: 100839 RVA: 0x00382FA1 File Offset: 0x003811A1
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPhotographSubTarget> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPhotographSubTarget>(data);
			return builder.EndVector();
		}

		// Token: 0x060189E8 RID: 100840 RVA: 0x00382FBF File Offset: 0x003811BF
		public static VectorOffset CreateSubTargetsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPhotographSubTarget>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x00382FD8 File Offset: 0x003811D8
		public static void StartSubTargetsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060189EA RID: 100842 RVA: 0x00382FE3 File Offset: 0x003811E3
		public static void AddSubTargets(FlatBufferBuilder builder, VectorOffset subTargetsOffset)
		{
			builder.AddOffset(4, subTargetsOffset.Value, 0);
		}

		// Token: 0x060189EB RID: 100843 RVA: 0x00382FF4 File Offset: 0x003811F4
		public static VectorOffset CreateSubTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060189EC RID: 100844 RVA: 0x0038302B File Offset: 0x0038122B
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060189ED RID: 100845 RVA: 0x00383045 File Offset: 0x00381245
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x00383063 File Offset: 0x00381263
		public static VectorOffset CreateSubTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x0038307C File Offset: 0x0038127C
		public static void StartSubTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060189F0 RID: 100848 RVA: 0x00383087 File Offset: 0x00381287
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060189F1 RID: 100849 RVA: 0x00383092 File Offset: 0x00381292
		public static Offset<IPhotographCondition> EndIPhotographCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCondition>(builder.EndTable());
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x003830A0 File Offset: 0x003812A0
		public IPhotographConditionT UnPack()
		{
			IPhotographConditionT photographConditionT = new IPhotographConditionT();
			this.UnPackTo(photographConditionT);
			return photographConditionT;
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x003830BC File Offset: 0x003812BC
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

		// Token: 0x060189F4 RID: 100852 RVA: 0x00383248 File Offset: 0x00381448
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

		// Token: 0x0400C3BA RID: 50106
		private Table __p;
	}
}
