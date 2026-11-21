using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006925 RID: 26917
	public struct ICatapult : IFlatbufferObject
	{
		// Token: 0x1700C627 RID: 50727
		// (get) Token: 0x0602E200 RID: 188928 RVA: 0x0064D774 File Offset: 0x0064B974
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E201 RID: 188929 RVA: 0x0064D781 File Offset: 0x0064B981
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E202 RID: 188930 RVA: 0x0064D788 File Offset: 0x0064B988
		public static ICatapult GetRootAsICatapult(ByteBuffer _bb)
		{
			return ICatapult.GetRootAsICatapult(_bb, default(ICatapult));
		}

		// Token: 0x0602E203 RID: 188931 RVA: 0x0064D7A4 File Offset: 0x0064B9A4
		public static ICatapult GetRootAsICatapult(ByteBuffer _bb, ICatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E204 RID: 188932 RVA: 0x0064D7C1 File Offset: 0x0064B9C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E205 RID: 188933 RVA: 0x0064D7D0 File Offset: 0x0064B9D0
		public ICatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C628 RID: 50728
		// (get) Token: 0x0602E206 RID: 188934 RVA: 0x0064D7E0 File Offset: 0x0064B9E0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C629 RID: 50729
		// (get) Token: 0x0602E207 RID: 188935 RVA: 0x0064D81C File Offset: 0x0064BA1C
		public ICatapultParam? Param
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICatapultParam?(default(ICatapultParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C62A RID: 50730
		// (get) Token: 0x0602E208 RID: 188936 RVA: 0x0064D87C File Offset: 0x0064BA7C
		public TCommonTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TCommonTarget.NONE;
				}
				return (TCommonTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E209 RID: 188937 RVA: 0x0064D8B8 File Offset: 0x0064BAB8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E20A RID: 188938 RVA: 0x0064D900 File Offset: 0x0064BB00
		public IAssistCharacterTarget TargetAsIAssistCharacterTarget()
		{
			return this.Target<IAssistCharacterTarget>().Value;
		}

		// Token: 0x0602E20B RID: 188939 RVA: 0x0064D91C File Offset: 0x0064BB1C
		public IPlayerTarget TargetAsIPlayerTarget()
		{
			return this.Target<IPlayerTarget>().Value;
		}

		// Token: 0x0602E20C RID: 188940 RVA: 0x0064D937 File Offset: 0x0064BB37
		public static Offset<ICatapult> CreateICatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<ICatapultParam> ParamOffset = default(Offset<ICatapultParam>), TCommonTarget Target_type = TCommonTarget.NONE, int TargetOffset = 0)
		{
			builder.StartTable(4);
			ICatapult.AddTarget(builder, TargetOffset);
			ICatapult.AddParam(builder, ParamOffset);
			ICatapult.AddTargetType(builder, Target_type);
			ICatapult.AddType(builder, Type);
			return ICatapult.EndICatapult(builder);
		}

		// Token: 0x0602E20D RID: 188941 RVA: 0x0064D963 File Offset: 0x0064BB63
		public static void StartICatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E20E RID: 188942 RVA: 0x0064D96C File Offset: 0x0064BB6C
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E20F RID: 188943 RVA: 0x0064D977 File Offset: 0x0064BB77
		public static void AddParam(FlatBufferBuilder builder, Offset<ICatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x0602E210 RID: 188944 RVA: 0x0064D987 File Offset: 0x0064BB87
		public static void AddTargetType(FlatBufferBuilder builder, TCommonTarget targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x0602E211 RID: 188945 RVA: 0x0064D992 File Offset: 0x0064BB92
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x0602E212 RID: 188946 RVA: 0x0064D99D File Offset: 0x0064BB9D
		public static Offset<ICatapult> EndICatapult(FlatBufferBuilder builder)
		{
			return new Offset<ICatapult>(builder.EndTable());
		}

		// Token: 0x0602E213 RID: 188947 RVA: 0x0064D9AC File Offset: 0x0064BBAC
		public ICatapultT UnPack()
		{
			ICatapultT catapultT = new ICatapultT();
			this.UnPackTo(catapultT);
			return catapultT;
		}

		// Token: 0x0602E214 RID: 188948 RVA: 0x0064D9C8 File Offset: 0x0064BBC8
		public void UnPackTo(ICatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
			_o.Target = new TCommonTargetUnion();
			_o.Target.Type = this.TargetType;
			TCommonTarget targetType = this.TargetType;
			if (targetType == TCommonTarget.IAssistCharacterTarget)
			{
				_o.Target.Value = ((this.Target<IAssistCharacterTarget>() != null) ? this.Target<IAssistCharacterTarget>().Value.UnPack() : null);
				return;
			}
			if (targetType != TCommonTarget.IPlayerTarget)
			{
				return;
			}
			_o.Target.Value = ((this.Target<IPlayerTarget>() != null) ? this.Target<IPlayerTarget>().Value.UnPack() : null);
		}

		// Token: 0x0602E215 RID: 188949 RVA: 0x0064DAAC File Offset: 0x0064BCAC
		public static Offset<ICatapult> Pack(FlatBufferBuilder builder, ICatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICatapult>);
			}
			Offset<ICatapultParam> paramOffset = (_o.Param == null) ? default(Offset<ICatapultParam>) : ICatapultParam.Pack(builder, _o.Param);
			TCommonTarget target_type = (_o.Target == null) ? TCommonTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCommonTargetUnion.Pack(builder, _o.Target);
			return ICatapult.CreateICatapult(builder, _o.Type, paramOffset, target_type, targetOffset);
		}

		// Token: 0x04011667 RID: 71271
		private Table __p;
	}
}
