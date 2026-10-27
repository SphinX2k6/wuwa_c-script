using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747E RID: 29822
	public struct ITriggeredVehicle : IFlatbufferObject
	{
		// Token: 0x1700E267 RID: 57959
		// (get) Token: 0x06036318 RID: 221976 RVA: 0x0075E411 File Offset: 0x0075C611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036319 RID: 221977 RVA: 0x0075E41E File Offset: 0x0075C61E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603631A RID: 221978 RVA: 0x0075E428 File Offset: 0x0075C628
		public static ITriggeredVehicle GetRootAsITriggeredVehicle(ByteBuffer _bb)
		{
			return ITriggeredVehicle.GetRootAsITriggeredVehicle(_bb, default(ITriggeredVehicle));
		}

		// Token: 0x0603631B RID: 221979 RVA: 0x0075E444 File Offset: 0x0075C644
		public static ITriggeredVehicle GetRootAsITriggeredVehicle(ByteBuffer _bb, ITriggeredVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603631C RID: 221980 RVA: 0x0075E461 File Offset: 0x0075C661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603631D RID: 221981 RVA: 0x0075E470 File Offset: 0x0075C670
		public ITriggeredVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E268 RID: 57960
		// (get) Token: 0x0603631E RID: 221982 RVA: 0x0075E480 File Offset: 0x0075C680
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603631F RID: 221983 RVA: 0x0075E4BC File Offset: 0x0075C6BC
		public static Offset<ITriggeredVehicle> CreateITriggeredVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ITriggeredVehicle.AddType(builder, Type);
			return ITriggeredVehicle.EndITriggeredVehicle(builder);
		}

		// Token: 0x06036320 RID: 221984 RVA: 0x0075E4D2 File Offset: 0x0075C6D2
		public static void StartITriggeredVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036321 RID: 221985 RVA: 0x0075E4DB File Offset: 0x0075C6DB
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036322 RID: 221986 RVA: 0x0075E4E6 File Offset: 0x0075C6E6
		public static Offset<ITriggeredVehicle> EndITriggeredVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredVehicle>(builder.EndTable());
		}

		// Token: 0x06036323 RID: 221987 RVA: 0x0075E4F4 File Offset: 0x0075C6F4
		public ITriggeredVehicleT UnPack()
		{
			ITriggeredVehicleT triggeredVehicleT = new ITriggeredVehicleT();
			this.UnPackTo(triggeredVehicleT);
			return triggeredVehicleT;
		}

		// Token: 0x06036324 RID: 221988 RVA: 0x0075E50F File Offset: 0x0075C70F
		public void UnPackTo(ITriggeredVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036325 RID: 221989 RVA: 0x0075E520 File Offset: 0x0075C720
		public static Offset<ITriggeredVehicle> Pack(FlatBufferBuilder builder, ITriggeredVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredVehicle>);
			}
			return ITriggeredVehicle.CreateITriggeredVehicle(builder, _o.Type);
		}

		// Token: 0x04012314 RID: 74516
		private Table __p;
	}
}
