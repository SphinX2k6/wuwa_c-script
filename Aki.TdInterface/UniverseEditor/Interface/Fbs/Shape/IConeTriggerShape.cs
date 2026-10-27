using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C04 RID: 15364
	public struct IConeTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006989 RID: 27017
		// (get) Token: 0x06015281 RID: 86657 RVA: 0x00310C58 File Offset: 0x0030EE58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015282 RID: 86658 RVA: 0x00310C65 File Offset: 0x0030EE65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015283 RID: 86659 RVA: 0x00310C6C File Offset: 0x0030EE6C
		public static IConeTriggerShape GetRootAsIConeTriggerShape(ByteBuffer _bb)
		{
			return IConeTriggerShape.GetRootAsIConeTriggerShape(_bb, default(IConeTriggerShape));
		}

		// Token: 0x06015284 RID: 86660 RVA: 0x00310C88 File Offset: 0x0030EE88
		public static IConeTriggerShape GetRootAsIConeTriggerShape(ByteBuffer _bb, IConeTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015285 RID: 86661 RVA: 0x00310CA5 File Offset: 0x0030EEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015286 RID: 86662 RVA: 0x00310CB4 File Offset: 0x0030EEB4
		public IConeTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700698A RID: 27018
		// (get) Token: 0x06015287 RID: 86663 RVA: 0x00310CC4 File Offset: 0x0030EEC4
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700698B RID: 27019
		// (get) Token: 0x06015288 RID: 86664 RVA: 0x00310D00 File Offset: 0x0030EF00
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700698C RID: 27020
		// (get) Token: 0x06015289 RID: 86665 RVA: 0x00310D60 File Offset: 0x0030EF60
		public int Radius
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

		// Token: 0x1700698D RID: 27021
		// (get) Token: 0x0601528A RID: 86666 RVA: 0x00310D9C File Offset: 0x0030EF9C
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601528B RID: 86667 RVA: 0x00310DD9 File Offset: 0x0030EFD9
		public static Offset<IConeTriggerShape> CreateIConeTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			IConeTriggerShape.AddHeight(builder, Height);
			IConeTriggerShape.AddRadius(builder, Radius);
			IConeTriggerShape.AddCenter(builder, CenterOffset);
			IConeTriggerShape.AddType(builder, Type);
			return IConeTriggerShape.EndIConeTriggerShape(builder);
		}

		// Token: 0x0601528C RID: 86668 RVA: 0x00310E05 File Offset: 0x0030F005
		public static void StartIConeTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x00310E0E File Offset: 0x0030F00E
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x00310E19 File Offset: 0x0030F019
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0601528F RID: 86671 RVA: 0x00310E29 File Offset: 0x0030F029
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06015290 RID: 86672 RVA: 0x00310E34 File Offset: 0x0030F034
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x06015291 RID: 86673 RVA: 0x00310E3F File Offset: 0x0030F03F
		public static Offset<IConeTriggerShape> EndIConeTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IConeTriggerShape>(builder.EndTable());
		}

		// Token: 0x06015292 RID: 86674 RVA: 0x00310E4C File Offset: 0x0030F04C
		public IConeTriggerShapeT UnPack()
		{
			IConeTriggerShapeT coneTriggerShapeT = new IConeTriggerShapeT();
			this.UnPackTo(coneTriggerShapeT);
			return coneTriggerShapeT;
		}

		// Token: 0x06015293 RID: 86675 RVA: 0x00310E68 File Offset: 0x0030F068
		public void UnPackTo(IConeTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x06015294 RID: 86676 RVA: 0x00310EC8 File Offset: 0x0030F0C8
		public static Offset<IConeTriggerShape> Pack(FlatBufferBuilder builder, IConeTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IConeTriggerShape.CreateIConeTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400B1D9 RID: 45529
		private Table __p;
	}
}
