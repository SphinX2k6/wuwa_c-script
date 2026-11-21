using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B98 RID: 19352
	public struct ICameraTemplate : IFlatbufferObject
	{
		// Token: 0x170088E9 RID: 35049
		// (get) Token: 0x0601D7FC RID: 120828 RVA: 0x0042449F File Offset: 0x0042269F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7FD RID: 120829 RVA: 0x004244AC File Offset: 0x004226AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7FE RID: 120830 RVA: 0x004244B4 File Offset: 0x004226B4
		public static ICameraTemplate GetRootAsICameraTemplate(ByteBuffer _bb)
		{
			return ICameraTemplate.GetRootAsICameraTemplate(_bb, default(ICameraTemplate));
		}

		// Token: 0x0601D7FF RID: 120831 RVA: 0x004244D0 File Offset: 0x004226D0
		public static ICameraTemplate GetRootAsICameraTemplate(ByteBuffer _bb, ICameraTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D800 RID: 120832 RVA: 0x004244ED File Offset: 0x004226ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D801 RID: 120833 RVA: 0x004244FC File Offset: 0x004226FC
		public ICameraTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088EA RID: 35050
		// (get) Token: 0x0601D802 RID: 120834 RVA: 0x0042450C File Offset: 0x0042270C
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

		// Token: 0x170088EB RID: 35051
		// (get) Token: 0x0601D803 RID: 120835 RVA: 0x00424548 File Offset: 0x00422748
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

		// Token: 0x0601D804 RID: 120836 RVA: 0x0042457F File Offset: 0x0042277F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D805 RID: 120837 RVA: 0x0042458E File Offset: 0x0042278E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170088EC RID: 35052
		// (get) Token: 0x0601D806 RID: 120838 RVA: 0x0042459C File Offset: 0x0042279C
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

		// Token: 0x170088ED RID: 35053
		// (get) Token: 0x0601D807 RID: 120839 RVA: 0x004245D8 File Offset: 0x004227D8
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170088EE RID: 35054
		// (get) Token: 0x0601D808 RID: 120840 RVA: 0x00424618 File Offset: 0x00422818
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

		// Token: 0x0601D809 RID: 120841 RVA: 0x00424650 File Offset: 0x00422850
		public Span<byte> GetTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601D80A RID: 120842 RVA: 0x00424660 File Offset: 0x00422860
		public byte[] GetTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170088EF RID: 35055
		// (get) Token: 0x0601D80B RID: 120843 RVA: 0x00424670 File Offset: 0x00422870
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

		// Token: 0x0601D80C RID: 120844 RVA: 0x004246A8 File Offset: 0x004228A8
		public Span<byte> GetCameraTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601D80D RID: 120845 RVA: 0x004246B8 File Offset: 0x004228B8
		public byte[] GetCameraTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0601D80E RID: 120846 RVA: 0x004246C8 File Offset: 0x004228C8
		public IPosA? ActorDataArray(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IPosA?(default(IPosA).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170088F0 RID: 35056
		// (get) Token: 0x0601D80F RID: 120847 RVA: 0x0042472C File Offset: 0x0042292C
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

		// Token: 0x170088F1 RID: 35057
		// (get) Token: 0x0601D810 RID: 120848 RVA: 0x00424758 File Offset: 0x00422958
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

		// Token: 0x0601D811 RID: 120849 RVA: 0x004247B8 File Offset: 0x004229B8
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

		// Token: 0x0601D812 RID: 120850 RVA: 0x0042480F File Offset: 0x00422A0F
		public static void StartICameraTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601D813 RID: 120851 RVA: 0x00424818 File Offset: 0x00422A18
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D814 RID: 120852 RVA: 0x00424823 File Offset: 0x00422A23
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601D815 RID: 120853 RVA: 0x00424833 File Offset: 0x00422A33
		public static void AddAmount(FlatBufferBuilder builder, int amount)
		{
			builder.AddInt(2, amount, 0);
		}

		// Token: 0x0601D816 RID: 120854 RVA: 0x0042483E File Offset: 0x00422A3E
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(3, enable, false);
		}

		// Token: 0x0601D817 RID: 120855 RVA: 0x00424849 File Offset: 0x00422A49
		public static void AddTemplate(FlatBufferBuilder builder, StringOffset templateOffset)
		{
			builder.AddOffset(4, templateOffset.Value, 0);
		}

		// Token: 0x0601D818 RID: 120856 RVA: 0x00424859 File Offset: 0x00422A59
		public static void AddCameraType(FlatBufferBuilder builder, StringOffset cameraTypeOffset)
		{
			builder.AddOffset(5, cameraTypeOffset.Value, 0);
		}

		// Token: 0x0601D819 RID: 120857 RVA: 0x00424869 File Offset: 0x00422A69
		public static void AddActorDataArray(FlatBufferBuilder builder, VectorOffset actorDataArrayOffset)
		{
			builder.AddOffset(6, actorDataArrayOffset.Value, 0);
		}

		// Token: 0x0601D81A RID: 120858 RVA: 0x0042487C File Offset: 0x00422A7C
		public static VectorOffset CreateActorDataArrayVector(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D81B RID: 120859 RVA: 0x004248BC File Offset: 0x00422ABC
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, Offset<IPosA>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D81C RID: 120860 RVA: 0x004248D6 File Offset: 0x00422AD6
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosA>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosA>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D81D RID: 120861 RVA: 0x004248F4 File Offset: 0x00422AF4
		public static VectorOffset CreateActorDataArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosA>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D81E RID: 120862 RVA: 0x0042490D File Offset: 0x00422B0D
		public static void StartActorDataArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D81F RID: 120863 RVA: 0x00424918 File Offset: 0x00422B18
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(7, cameraDataOffset.Value, 0);
		}

		// Token: 0x0601D820 RID: 120864 RVA: 0x00424928 File Offset: 0x00422B28
		public static Offset<ICameraTemplate> EndICameraTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ICameraTemplate>(builder.EndTable());
		}

		// Token: 0x0601D821 RID: 120865 RVA: 0x00424938 File Offset: 0x00422B38
		public ICameraTemplateT UnPack()
		{
			ICameraTemplateT cameraTemplateT = new ICameraTemplateT();
			this.UnPackTo(cameraTemplateT);
			return cameraTemplateT;
		}

		// Token: 0x0601D822 RID: 120866 RVA: 0x00424954 File Offset: 0x00422B54
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

		// Token: 0x0601D823 RID: 120867 RVA: 0x00424A2C File Offset: 0x00422C2C
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

		// Token: 0x0400D43E RID: 54334
		private Table __p;
	}
}
