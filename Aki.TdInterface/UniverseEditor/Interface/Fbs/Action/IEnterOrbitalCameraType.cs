using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D40 RID: 27968
	public struct IEnterOrbitalCameraType : IFlatbufferObject
	{
		// Token: 0x1700CD31 RID: 52529
		// (get) Token: 0x060303ED RID: 197613 RVA: 0x0068EFC0 File Offset: 0x0068D1C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060303EE RID: 197614 RVA: 0x0068EFCD File Offset: 0x0068D1CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060303EF RID: 197615 RVA: 0x0068EFD4 File Offset: 0x0068D1D4
		public static IEnterOrbitalCameraType GetRootAsIEnterOrbitalCameraType(ByteBuffer _bb)
		{
			return IEnterOrbitalCameraType.GetRootAsIEnterOrbitalCameraType(_bb, default(IEnterOrbitalCameraType));
		}

		// Token: 0x060303F0 RID: 197616 RVA: 0x0068EFF0 File Offset: 0x0068D1F0
		public static IEnterOrbitalCameraType GetRootAsIEnterOrbitalCameraType(ByteBuffer _bb, IEnterOrbitalCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060303F1 RID: 197617 RVA: 0x0068F00D File Offset: 0x0068D20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060303F2 RID: 197618 RVA: 0x0068F01C File Offset: 0x0068D21C
		public IEnterOrbitalCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD32 RID: 52530
		// (get) Token: 0x060303F3 RID: 197619 RVA: 0x0068F02C File Offset: 0x0068D22C
		public EEnterOrbitalCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnterOrbitalCameraType.ControlByMove;
				}
				return (EEnterOrbitalCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060303F4 RID: 197620 RVA: 0x0068F068 File Offset: 0x0068D268
		public static Offset<IEnterOrbitalCameraType> CreateIEnterOrbitalCameraType(FlatBufferBuilder builder, EEnterOrbitalCameraType Type = EEnterOrbitalCameraType.ControlByMove)
		{
			builder.StartTable(1);
			IEnterOrbitalCameraType.AddType(builder, Type);
			return IEnterOrbitalCameraType.EndIEnterOrbitalCameraType(builder);
		}

		// Token: 0x060303F5 RID: 197621 RVA: 0x0068F07E File Offset: 0x0068D27E
		public static void StartIEnterOrbitalCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060303F6 RID: 197622 RVA: 0x0068F087 File Offset: 0x0068D287
		public static void AddType(FlatBufferBuilder builder, EEnterOrbitalCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060303F7 RID: 197623 RVA: 0x0068F092 File Offset: 0x0068D292
		public static Offset<IEnterOrbitalCameraType> EndIEnterOrbitalCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCameraType>(builder.EndTable());
		}

		// Token: 0x060303F8 RID: 197624 RVA: 0x0068F0A0 File Offset: 0x0068D2A0
		public IEnterOrbitalCameraTypeT UnPack()
		{
			IEnterOrbitalCameraTypeT enterOrbitalCameraTypeT = new IEnterOrbitalCameraTypeT();
			this.UnPackTo(enterOrbitalCameraTypeT);
			return enterOrbitalCameraTypeT;
		}

		// Token: 0x060303F9 RID: 197625 RVA: 0x0068F0BB File Offset: 0x0068D2BB
		public void UnPackTo(IEnterOrbitalCameraTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060303FA RID: 197626 RVA: 0x0068F0CC File Offset: 0x0068D2CC
		public static Offset<IEnterOrbitalCameraType> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCameraType>);
			}
			return IEnterOrbitalCameraType.CreateIEnterOrbitalCameraType(builder, _o.Type);
		}

		// Token: 0x04011BB5 RID: 72629
		private Table __p;
	}
}
