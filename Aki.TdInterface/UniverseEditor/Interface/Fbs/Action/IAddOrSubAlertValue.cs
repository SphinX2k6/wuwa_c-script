using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612E RID: 24878
	public struct IAddOrSubAlertValue : IFlatbufferObject
	{
		// Token: 0x1700B75C RID: 46940
		// (get) Token: 0x0602A86F RID: 174191 RVA: 0x005DB2B0 File Offset: 0x005D94B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A870 RID: 174192 RVA: 0x005DB2BD File Offset: 0x005D94BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A871 RID: 174193 RVA: 0x005DB2C4 File Offset: 0x005D94C4
		public static IAddOrSubAlertValue GetRootAsIAddOrSubAlertValue(ByteBuffer _bb)
		{
			return IAddOrSubAlertValue.GetRootAsIAddOrSubAlertValue(_bb, default(IAddOrSubAlertValue));
		}

		// Token: 0x0602A872 RID: 174194 RVA: 0x005DB2E0 File Offset: 0x005D94E0
		public static IAddOrSubAlertValue GetRootAsIAddOrSubAlertValue(ByteBuffer _bb, IAddOrSubAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A873 RID: 174195 RVA: 0x005DB2FD File Offset: 0x005D94FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A874 RID: 174196 RVA: 0x005DB30C File Offset: 0x005D950C
		public IAddOrSubAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B75D RID: 46941
		// (get) Token: 0x0602A875 RID: 174197 RVA: 0x005DB31C File Offset: 0x005D951C
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B75E RID: 46942
		// (get) Token: 0x0602A876 RID: 174198 RVA: 0x005DB358 File Offset: 0x005D9558
		public float DeltaValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A877 RID: 174199 RVA: 0x005DB398 File Offset: 0x005D9598
		public static Offset<IAddOrSubAlertValue> CreateIAddOrSubAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub, float DeltaValue = 0f)
		{
			builder.StartTable(2);
			IAddOrSubAlertValue.AddDeltaValue(builder, DeltaValue);
			IAddOrSubAlertValue.AddType(builder, Type);
			return IAddOrSubAlertValue.EndIAddOrSubAlertValue(builder);
		}

		// Token: 0x0602A878 RID: 174200 RVA: 0x005DB3B5 File Offset: 0x005D95B5
		public static void StartIAddOrSubAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A879 RID: 174201 RVA: 0x005DB3BE File Offset: 0x005D95BE
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A87A RID: 174202 RVA: 0x005DB3C9 File Offset: 0x005D95C9
		public static void AddDeltaValue(FlatBufferBuilder builder, float deltaValue)
		{
			builder.AddFloat(1, deltaValue, 0.0);
		}

		// Token: 0x0602A87B RID: 174203 RVA: 0x005DB3DC File Offset: 0x005D95DC
		public static Offset<IAddOrSubAlertValue> EndIAddOrSubAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IAddOrSubAlertValue>(builder.EndTable());
		}

		// Token: 0x0602A87C RID: 174204 RVA: 0x005DB3EC File Offset: 0x005D95EC
		public IAddOrSubAlertValueT UnPack()
		{
			IAddOrSubAlertValueT addOrSubAlertValueT = new IAddOrSubAlertValueT();
			this.UnPackTo(addOrSubAlertValueT);
			return addOrSubAlertValueT;
		}

		// Token: 0x0602A87D RID: 174205 RVA: 0x005DB407 File Offset: 0x005D9607
		public void UnPackTo(IAddOrSubAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.DeltaValue = this.DeltaValue;
		}

		// Token: 0x0602A87E RID: 174206 RVA: 0x005DB424 File Offset: 0x005D9624
		public static Offset<IAddOrSubAlertValue> Pack(FlatBufferBuilder builder, IAddOrSubAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddOrSubAlertValue>);
			}
			return IAddOrSubAlertValue.CreateIAddOrSubAlertValue(builder, _o.Type, _o.DeltaValue);
		}

		// Token: 0x04010503 RID: 66819
		private Table __p;
	}
}
