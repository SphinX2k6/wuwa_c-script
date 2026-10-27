using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A45 RID: 19013
	public struct ICheckHasFollowShooter : IFlatbufferObject
	{
		// Token: 0x170089A4 RID: 35236
		// (get) Token: 0x0601DC56 RID: 121942 RVA: 0x0042F9CA File Offset: 0x0042DBCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC57 RID: 121943 RVA: 0x0042F9D7 File Offset: 0x0042DBD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC58 RID: 121944 RVA: 0x0042F9E0 File Offset: 0x0042DBE0
		public static ICheckHasFollowShooter GetRootAsICheckHasFollowShooter(ByteBuffer _bb)
		{
			return ICheckHasFollowShooter.GetRootAsICheckHasFollowShooter(_bb, default(ICheckHasFollowShooter));
		}

		// Token: 0x0601DC59 RID: 121945 RVA: 0x0042F9FC File Offset: 0x0042DBFC
		public static ICheckHasFollowShooter GetRootAsICheckHasFollowShooter(ByteBuffer _bb, ICheckHasFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC5A RID: 121946 RVA: 0x0042FA19 File Offset: 0x0042DC19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC5B RID: 121947 RVA: 0x0042FA28 File Offset: 0x0042DC28
		public ICheckHasFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089A5 RID: 35237
		// (get) Token: 0x0601DC5C RID: 121948 RVA: 0x0042FA38 File Offset: 0x0042DC38
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089A6 RID: 35238
		// (get) Token: 0x0601DC5D RID: 121949 RVA: 0x0042FA74 File Offset: 0x0042DC74
		public bool Has
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089A7 RID: 35239
		// (get) Token: 0x0601DC5E RID: 121950 RVA: 0x0042FAB4 File Offset: 0x0042DCB4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC5F RID: 121951 RVA: 0x0042FAF0 File Offset: 0x0042DCF0
		public static Offset<ICheckHasFollowShooter> CreateICheckHasFollowShooter(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Has = false, int Id = 0)
		{
			builder.StartTable(3);
			ICheckHasFollowShooter.AddId(builder, Id);
			ICheckHasFollowShooter.AddHas(builder, Has);
			ICheckHasFollowShooter.AddType(builder, Type);
			return ICheckHasFollowShooter.EndICheckHasFollowShooter(builder);
		}

		// Token: 0x0601DC60 RID: 121952 RVA: 0x0042FB14 File Offset: 0x0042DD14
		public static void StartICheckHasFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DC61 RID: 121953 RVA: 0x0042FB1D File Offset: 0x0042DD1D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC62 RID: 121954 RVA: 0x0042FB28 File Offset: 0x0042DD28
		public static void AddHas(FlatBufferBuilder builder, bool has)
		{
			builder.AddBool(1, has, false);
		}

		// Token: 0x0601DC63 RID: 121955 RVA: 0x0042FB33 File Offset: 0x0042DD33
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x0601DC64 RID: 121956 RVA: 0x0042FB3E File Offset: 0x0042DD3E
		public static Offset<ICheckHasFollowShooter> EndICheckHasFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHasFollowShooter>(builder.EndTable());
		}

		// Token: 0x0601DC65 RID: 121957 RVA: 0x0042FB4C File Offset: 0x0042DD4C
		public ICheckHasFollowShooterT UnPack()
		{
			ICheckHasFollowShooterT checkHasFollowShooterT = new ICheckHasFollowShooterT();
			this.UnPackTo(checkHasFollowShooterT);
			return checkHasFollowShooterT;
		}

		// Token: 0x0601DC66 RID: 121958 RVA: 0x0042FB67 File Offset: 0x0042DD67
		public void UnPackTo(ICheckHasFollowShooterT _o)
		{
			_o.Type = this.Type;
			_o.Has = this.Has;
			_o.Id = this.Id;
		}

		// Token: 0x0601DC67 RID: 121959 RVA: 0x0042FB90 File Offset: 0x0042DD90
		public static Offset<ICheckHasFollowShooter> Pack(FlatBufferBuilder builder, ICheckHasFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHasFollowShooter>);
			}
			return ICheckHasFollowShooter.CreateICheckHasFollowShooter(builder, _o.Type, _o.Has, _o.Id);
		}

		// Token: 0x0400D29B RID: 53915
		private Table __p;
	}
}
