using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BB RID: 4795
	public sealed class SunSpiritPb : IMessage<SunSpiritPb>, IMessage, IEquatable<SunSpiritPb>, IDeepCloneable<SunSpiritPb>, IBufferMessage
	{
		// Token: 0x06019838 RID: 104504 RVA: 0x003B5325 File Offset: 0x003B3525
		[NullableContext(1)]
		public static SunSpiritPb Create()
		{
			return new SunSpiritPb();
		}

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x06019839 RID: 104505 RVA: 0x003B532C File Offset: 0x003B352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SunSpiritPb> Parser
		{
			get
			{
				return SunSpiritPb._parser;
			}
		}

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x0601983A RID: 104506 RVA: 0x003B5333 File Offset: 0x003B3533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x0601983B RID: 104507 RVA: 0x003B5336 File Offset: 0x003B3536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritPb.Descriptor;
			}
		}

		// Token: 0x0601983C RID: 104508 RVA: 0x003B533D File Offset: 0x003B353D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb()
		{
		}

		// Token: 0x0601983D RID: 104509 RVA: 0x003B5348 File Offset: 0x003B3548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb(SunSpiritPb other) : this()
		{
			this.instId_ = other.instId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.takeUpData_ = ((other.takeUpData_ != null) ? other.takeUpData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601983E RID: 104510 RVA: 0x003B53A0 File Offset: 0x003B35A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritPb Clone()
		{
			return new SunSpiritPb(this);
		}

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x0601983F RID: 104511 RVA: 0x003B53A8 File Offset: 0x003B35A8
		// (set) Token: 0x06019840 RID: 104512 RVA: 0x003B53B0 File Offset: 0x003B35B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x06019841 RID: 104513 RVA: 0x003B53B9 File Offset: 0x003B35B9
		// (set) Token: 0x06019842 RID: 104514 RVA: 0x003B53C1 File Offset: 0x003B35C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x06019843 RID: 104515 RVA: 0x003B53CA File Offset: 0x003B35CA
		// (set) Token: 0x06019844 RID: 104516 RVA: 0x003B53D2 File Offset: 0x003B35D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb TakeUpData
		{
			get
			{
				return this.takeUpData_;
			}
			set
			{
				this.takeUpData_ = value;
			}
		}

		// Token: 0x06019845 RID: 104517 RVA: 0x003B53DB File Offset: 0x003B35DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritPb);
		}

		// Token: 0x06019846 RID: 104518 RVA: 0x003B53EC File Offset: 0x003B35EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritPb other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityConfigId == other.EntityConfigId && object.Equals(this.TakeUpData, other.TakeUpData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019847 RID: 104519 RVA: 0x003B544C File Offset: 0x003B364C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.takeUpData_ != null)
			{
				num ^= this.TakeUpData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019848 RID: 104520 RVA: 0x003B54BA File Offset: 0x003B36BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019849 RID: 104521 RVA: 0x003B54C7 File Offset: 0x003B36C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601984A RID: 104522 RVA: 0x003B54D0 File Offset: 0x003B36D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.takeUpData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TakeUpData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601984B RID: 104523 RVA: 0x003B5544 File Offset: 0x003B3744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.takeUpData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TakeUpData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601984C RID: 104524 RVA: 0x003B55B4 File Offset: 0x003B37B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.takeUpData_ != null)
			{
				if (this.takeUpData_ == null)
				{
					this.TakeUpData = new SunSpiritTakeUpPb();
				}
				this.TakeUpData.MergeFrom(other.TakeUpData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601984D RID: 104525 RVA: 0x003B5630 File Offset: 0x003B3830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601984E RID: 104526 RVA: 0x003B563C File Offset: 0x003B383C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.takeUpData_ == null)
							{
								this.TakeUpData = new SunSpiritTakeUpPb();
							}
							input.ReadMessage(this.TakeUpData);
						}
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095AB RID: 38315
		private static readonly MessageParser<SunSpiritPb> _parser = new MessageParser<SunSpiritPb>(() => new SunSpiritPb());

		// Token: 0x040095AC RID: 38316
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095AD RID: 38317
		public const int InstIdFieldNumber = 1;

		// Token: 0x040095AE RID: 38318
		private int instId_;

		// Token: 0x040095AF RID: 38319
		public const int EntityConfigIdFieldNumber = 2;

		// Token: 0x040095B0 RID: 38320
		private int entityConfigId_;

		// Token: 0x040095B1 RID: 38321
		public const int TakeUpDataFieldNumber = 3;

		// Token: 0x040095B2 RID: 38322
		private SunSpiritTakeUpPb takeUpData_;
	}
}
