using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C8 RID: 1480
	[NetMessage(EMessageId.FloroRanchPlayRemoveUnitRequest)]
	public sealed class FloroRanchPlayRemoveUnitRequest : IMessage<FloroRanchPlayRemoveUnitRequest>, IMessage, IEquatable<FloroRanchPlayRemoveUnitRequest>, IDeepCloneable<FloroRanchPlayRemoveUnitRequest>, IBufferMessage
	{
		// Token: 0x060088C2 RID: 35010 RVA: 0x0014982F File Offset: 0x00147A2F
		[NullableContext(1)]
		public static FloroRanchPlayRemoveUnitRequest Create()
		{
			return new FloroRanchPlayRemoveUnitRequest();
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x00149836 File Offset: 0x00147A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060088C4 RID: 35012 RVA: 0x00149839 File Offset: 0x00147A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRemoveUnitRequest.Descriptor;
			}
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x00149840 File Offset: 0x00147A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest()
		{
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x00149848 File Offset: 0x00147A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest(FloroRanchPlayRemoveUnitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.unitIncId_ = other.unitIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x00149885 File Offset: 0x00147A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitRequest Clone()
		{
			return new FloroRanchPlayRemoveUnitRequest(this);
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x060088C8 RID: 35016 RVA: 0x0014988D File Offset: 0x00147A8D
		// (set) Token: 0x060088C9 RID: 35017 RVA: 0x00149895 File Offset: 0x00147A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x060088CA RID: 35018 RVA: 0x0014989E File Offset: 0x00147A9E
		// (set) Token: 0x060088CB RID: 35019 RVA: 0x001498A6 File Offset: 0x00147AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x060088CC RID: 35020 RVA: 0x001498AF File Offset: 0x00147AAF
		// (set) Token: 0x060088CD RID: 35021 RVA: 0x001498B7 File Offset: 0x00147AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnitIncId
		{
			get
			{
				return this.unitIncId_;
			}
			set
			{
				this.unitIncId_ = value;
			}
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x001498C0 File Offset: 0x00147AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRemoveUnitRequest);
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x001498D0 File Offset: 0x00147AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRemoveUnitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.UnitIncId == other.UnitIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0014992C File Offset: 0x00147B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.UnitIncId != 0)
			{
				num ^= this.UnitIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x0014999D File Offset: 0x00147B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x001499AA File Offset: 0x00147BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x001499B4 File Offset: 0x00147BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.UnitIncId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.UnitIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x00149A2C File Offset: 0x00147C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.UnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnitIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x00149A9C File Offset: 0x00147C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRemoveUnitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.UnitIncId != 0)
			{
				this.UnitIncId = other.UnitIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x00149B00 File Offset: 0x00147D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x00149B0C File Offset: 0x00147D0C
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnitIncId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004349 RID: 17225
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400434A RID: 17226
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400434B RID: 17227
		private int activityId_;

		// Token: 0x0400434C RID: 17228
		public const int SubInsIdFieldNumber = 6;

		// Token: 0x0400434D RID: 17229
		private int subInsId_;

		// Token: 0x0400434E RID: 17230
		public const int UnitIncIdFieldNumber = 15;

		// Token: 0x0400434F RID: 17231
		private int unitIncId_;
	}
}
