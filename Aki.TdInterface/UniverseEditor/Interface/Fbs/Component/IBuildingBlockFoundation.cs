using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F34 RID: 20276
	public struct IBuildingBlockFoundation : IFlatbufferObject
	{
		// Token: 0x17009228 RID: 37416
		// (get) Token: 0x06020185 RID: 131461 RVA: 0x00477270 File Offset: 0x00475470
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020186 RID: 131462 RVA: 0x0047727D File Offset: 0x0047547D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020187 RID: 131463 RVA: 0x00477284 File Offset: 0x00475484
		public static IBuildingBlockFoundation GetRootAsIBuildingBlockFoundation(ByteBuffer _bb)
		{
			return IBuildingBlockFoundation.GetRootAsIBuildingBlockFoundation(_bb, default(IBuildingBlockFoundation));
		}

		// Token: 0x06020188 RID: 131464 RVA: 0x004772A0 File Offset: 0x004754A0
		public static IBuildingBlockFoundation GetRootAsIBuildingBlockFoundation(ByteBuffer _bb, IBuildingBlockFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020189 RID: 131465 RVA: 0x004772BD File Offset: 0x004754BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602018A RID: 131466 RVA: 0x004772CC File Offset: 0x004754CC
		public IBuildingBlockFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009229 RID: 37417
		// (get) Token: 0x0602018B RID: 131467 RVA: 0x004772DC File Offset: 0x004754DC
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602018C RID: 131468 RVA: 0x00477318 File Offset: 0x00475518
		public static Offset<IBuildingBlockFoundation> CreateIBuildingBlockFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IBuildingBlockFoundation.AddType(builder, Type);
			return IBuildingBlockFoundation.EndIBuildingBlockFoundation(builder);
		}

		// Token: 0x0602018D RID: 131469 RVA: 0x0047732E File Offset: 0x0047552E
		public static void StartIBuildingBlockFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602018E RID: 131470 RVA: 0x00477337 File Offset: 0x00475537
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602018F RID: 131471 RVA: 0x00477342 File Offset: 0x00475542
		public static Offset<IBuildingBlockFoundation> EndIBuildingBlockFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IBuildingBlockFoundation>(builder.EndTable());
		}

		// Token: 0x06020190 RID: 131472 RVA: 0x00477350 File Offset: 0x00475550
		public IBuildingBlockFoundationT UnPack()
		{
			IBuildingBlockFoundationT buildingBlockFoundationT = new IBuildingBlockFoundationT();
			this.UnPackTo(buildingBlockFoundationT);
			return buildingBlockFoundationT;
		}

		// Token: 0x06020191 RID: 131473 RVA: 0x0047736B File Offset: 0x0047556B
		public void UnPackTo(IBuildingBlockFoundationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020192 RID: 131474 RVA: 0x0047737C File Offset: 0x0047557C
		public static Offset<IBuildingBlockFoundation> Pack(FlatBufferBuilder builder, IBuildingBlockFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuildingBlockFoundation>);
			}
			return IBuildingBlockFoundation.CreateIBuildingBlockFoundation(builder, _o.Type);
		}

		// Token: 0x0400DD9C RID: 56732
		private Table __p;
	}
}
