using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEF RID: 2799
	[NetMessage(EMessageId.NewbieCarnivalAwardRequest)]
	public sealed class NewbieCarnivalAwardRequest : IMessage<NewbieCarnivalAwardRequest>, IMessage, IEquatable<NewbieCarnivalAwardRequest>, IDeepCloneable<NewbieCarnivalAwardRequest>, IBufferMessage
	{
		// Token: 0x0600F3AE RID: 62382 RVA: 0x002398CD File Offset: 0x00237ACD
		[NullableContext(1)]
		public static NewbieCarnivalAwardRequest Create()
		{
			return new NewbieCarnivalAwardRequest();
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600F3AF RID: 62383 RVA: 0x002398D4 File Offset: 0x00237AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x002398D7 File Offset: 0x00237AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalAwardRequest.Descriptor;
			}
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x002398DE File Offset: 0x00237ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest()
		{
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x002398E6 File Offset: 0x00237AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest(NewbieCarnivalAwardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.config_ = other.config_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x00239917 File Offset: 0x00237B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardRequest Clone()
		{
			return new NewbieCarnivalAwardRequest(this);
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x0023991F File Offset: 0x00237B1F
		// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x00239927 File Offset: 0x00237B27
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

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x00239930 File Offset: 0x00237B30
		// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x00239938 File Offset: 0x00237B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Config
		{
			get
			{
				return this.config_;
			}
			set
			{
				this.config_ = value;
			}
		}

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x00239941 File Offset: 0x00237B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalAwardRequest);
		}

		// Token: 0x0600F3B9 RID: 62393 RVA: 0x0023994F File Offset: 0x00237B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalAwardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Config == other.Config && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3BA RID: 62394 RVA: 0x00239990 File Offset: 0x00237B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Config != 0)
			{
				num ^= this.Config.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x002399E8 File Offset: 0x00237BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x002399F5 File Offset: 0x00237BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3BD RID: 62397 RVA: 0x00239A00 File Offset: 0x00237C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Config != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Config);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x00239A5C File Offset: 0x00237C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Config != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Config);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x00239AB4 File Offset: 0x00237CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Config != 0)
			{
				this.Config = other.Config;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F3C0 RID: 62400 RVA: 0x00239B04 File Offset: 0x00237D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x00239B10 File Offset: 0x00237D10
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Config = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006290 RID: 25232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006291 RID: 25233
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04006292 RID: 25234
		private int activityId_;

		// Token: 0x04006293 RID: 25235
		public const int ConfigFieldNumber = 4;

		// Token: 0x04006294 RID: 25236
		private int config_;
	}
}
