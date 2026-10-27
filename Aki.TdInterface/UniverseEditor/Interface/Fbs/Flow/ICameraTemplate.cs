using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004730 RID: 18224
	public struct ICameraTemplate : IFlatbufferObject
	{
		// Token: 0x170082A8 RID: 33448
		// (get) Token: 0x0601C027 RID: 114727 RVA: 0x003F8203 File Offset: 0x003F6403
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x003F8210 File Offset: 0x003F6410
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C029 RID: 114729 RVA: 0x003F8218 File Offset: 0x003F6418
		public static ICameraTemplate GetRootAsICameraTemplate(ByteBuffer _bb)
		{
			return ICameraTemplate.GetRootAsICameraTemplate(_bb, default(ICameraTemplate));
		}

		// Token: 0x0601C02A RID: 114730 RVA: 0x003F8234 File Offset: 0x003F6434
		public static ICameraTemplate GetRootAsICameraTemplate(ByteBuffer _bb, ICameraTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C02B RID: 114731 RVA: 0x003F8251 File Offset: 0x003F6451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C02C RID: 114732 RVA: 0x003F8260 File Offset: 0x003F6460
		public ICameraTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082A9 RID: 33449
		// (get) Token: 0x0601C02D RID: 114733 RVA: 0x003F8270 File Offset: 0x003F6470
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082AA RID: 33450
		// (get) Token: 0x0601C02E RID: 114734 RVA: 0x003F82AC File Offset: 0x003F64AC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C02F RID: 114735 RVA: 0x003F82E3 File Offset: 0x003F64E3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C030 RID: 114736 RVA: 0x003F82F2 File Offset: 0x003F64F2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170082AB RID: 33451
		// (get) Token: 0x0601C031 RID: 114737 RVA: 0x003F8300 File Offset: 0x003F6500
		public int Amount
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

		// Token: 0x170082AC RID: 33452
		// (get) Token: 0x0601C032 RID: 114738 RVA: 0x003F833C File Offset: 0x003F653C
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082AD RID: 33453
		// (get) Token: 0x0601C033 RID: 114739 RVA: 0x003F837C File Offset: 0x003F657C
		public string Template
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C034 RID: 114740 RVA: 0x003F83B4 File Offset: 0x003F65B4
		public Span<byte> GetTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601C035 RID: 114741 RVA: 0x003F83C4 File Offset: 0x003F65C4
		public byte[] GetTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170082AE RID: 33454
		// (get) Token: 0x0601C036 RID: 114742 RVA: 0x003F83D4 File Offset: 0x003F65D4
		public string CameraType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C037 RID: 114743 RVA: 0x003F840C File Offset: 0x003F660C
		public Span<byte> GetCameraTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C038 RID: 114744 RVA: 0x003F841C File Offset: 0x003F661C
		public byte[] GetCameraTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0601C039 RID: 114745 RVA: 0x003F842C File Offset: 0x003F662C
		public IPosA? ActorDataArray(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IPosA?(default(IPosA).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082AF RID: 33455
		// (get) Token: 0x0601C03A RID: 114746 RVA: 0x003F8490 File Offset: 0x003F6690
		public int ActorDataArrayLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170082B0 RID: 33456
		// (get) Token: 0x0601C03B RID: 114747 RVA: 0x003F84BC File Offset: 0x003F66BC
		public ICameraData? CameraData
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ICameraData?(default(ICameraData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C03C RID: 114748 RVA: 0x003F851C File Offset: 0x003F671C
		public static Offset<ICameraTemplate> CreateICameraTemplate(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), int Amount = 0, bool Enable = false, StringOffset TemplateOffset = default(StringOffset), StringOffset CameraTypeOffset = default(StringOffset), VectorOffset ActorDataArrayOffset = default(VectorOffset), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>))
		{
			builder.StartTable(8);
			ICameraTemplate.AddCameraData(builder, CameraDataOffset);
			ICameraTemplate.AddActorDataArray(builder, ActorDataArrayOffset);
			ICameraTemplate.AddCameraType(builder, CameraTypeOffset);
			ICameraTemplate.AddTemplate(builder, TemplateOffset);
			ICameraTemplate.AddAmount(builder, Amount);
			ICameraTemplate.AddName(builder, NameOffset);
			ICameraTemplate.AddId(builder, Id);
			ICameraTemplate.AddEnable(builder, Enable);
			return ICameraTemplate.EndICameraTemplate(builder);
		}

		// Token: 0x0601C03D RID: 114749 RVA: 0x003F8573 File Offset: 0x003F6773
		public static void StartICameraTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601C03E RID: 114750 RVA: 0x003F857C File Offset: 0x003F677C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C03F RID: 114751 RVA: 0x003F8587 File Offset: 0x003F6787
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601C040 RID: 114752 RVA: 0x003F8597 File Offset: 0x003F6797
		public static void AddAmount(FlatBufferBuilder builder, int amount)
		{
			builder.AddInt(2, amount, 0);
		}

		// Token: 0x0601C041 RID: 114753 RVA: 0x003F85A2 File Offset: 0x003F67A2
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(3, enable, false);
		}

		// Token: 0x0601C042 RID: 114754 RVA: 0x003F85AD File Offset: 0x003F67AD
		public static void AddTemplate(FlatBufferBuilder builder, StringOffset templateOffset)
		{
			builder.AddOffset(4, templateOffset.Value, 0);
		}

		// Token: 0x0601C043 RID: 114755 RVA: 0x003F85BD File Offset: 0x003F67BD
		public static void AddCameraType(FlatBufferBuilder builder, StringOffset cameraTypeOffset)
		{
			builder.AddOffset(5, cameraTypeOffset.Value, 0);
		}

		// Token: 0x0601C044 RID: 114756 RVA: 0x003F85CD File Offset: 0x003F67CD
		public static void AddActorDataArray(FlatBufferBuilder builder, VectorOffset actorDataArrayOffset)
		{
			builder.AddOffset(6, actorDataArrayOffset.Value, 0);
		}

		// Token: 0x0601C045 RID: 114757 RVA: 0x003F85E0 File Offset: 0x003F67E0
		public static VectorOffset CreateActorDataArrayVector(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C046 RID: 114758 RVA: 0x003F8620 File Offset: 0x003F6820
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C047 RID: 114759 RVA: 0x003F863A File Offset: 0x003F683A
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosA>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C048 RID: 114760 RVA: 0x003F8658 File Offset: 0x003F6858
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosA>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C049 RID: 114761 RVA: 0x003F8671 File Offset: 0x003F6871
		public static void StartActorDataArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C04A RID: 114762 RVA: 0x003F867C File Offset: 0x003F687C
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(7, cameraDataOffset.Value, 0);
		}

		// Token: 0x0601C04B RID: 114763 RVA: 0x003F868C File Offset: 0x003F688C
		public static Offset<ICameraTemplate> EndICameraTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ICameraTemplate>(builder.EndTable());
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x003F869C File Offset: 0x003F689C
		public ICameraTemplateT UnPack()
		{
			ICameraTemplateT cameraTemplateT = new ICameraTemplateT();
			this.UnPackTo(cameraTemplateT);
			return cameraTemplateT;
		}

		// Token: 0x0601C04D RID: 114765 RVA: 0x003F86B8 File Offset: 0x003F68B8
		public void UnPackTo(ICameraTemplateT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Amount = this.Amount;
			_o.Enable = this.Enable;
			_o.Template = this.Template;
			_o.CameraType = this.CameraType;
			_o.ActorDataArray = new List<IPosAT>();
			for (int i = 0; i < this.ActorDataArrayLength; i++)
			{
				_o.ActorDataArray.Add((this.ActorDataArray(i) != null) ? this.ActorDataArray(i).Value.UnPack() : null);
			}
			_o.CameraData = ((this.CameraData != null) ? this.CameraData.Value.UnPack() : null);
		}

		// Token: 0x0601C04E RID: 114766 RVA: 0x003F8790 File Offset: 0x003F6990
		public static Offset<ICameraTemplate> Pack(FlatBufferBuilder builder, ICameraTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraTemplate>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset templateOffset = (_o.Template == null) ? default(StringOffset) : builder.CreateString(_o.Template);
			StringOffset cameraTypeOffset = (_o.CameraType == null) ? default(StringOffset) : builder.CreateString(_o.CameraType);
			VectorOffset actorDataArrayOffset = default(VectorOffset);
			if (_o.ActorDataArray != null)
			{
				Offset<IPosA>[] array = new Offset<IPosA>[_o.ActorDataArray.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPosA.Pack(builder, _o.ActorDataArray[i]);
				}
				actorDataArrayOffset = ICameraTemplate.CreateActorDataArrayVector(builder, array);
			}
			Offset<ICameraData> cameraDataOffset = (_o.CameraData == null) ? default(Offset<ICameraData>) : ICameraData.Pack(builder, _o.CameraData);
			return ICameraTemplate.CreateICameraTemplate(builder, _o.Id, nameOffset, _o.Amount, _o.Enable, templateOffset, cameraTypeOffset, actorDataArrayOffset, cameraDataOffset);
		}

		// Token: 0x0400CA0F RID: 51727
		private Table __p;
	}
}
