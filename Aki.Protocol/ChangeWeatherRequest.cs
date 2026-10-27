using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000266 RID: 614
	[NetMessage(EMessageId.ChangeWeatherRequest)]
	public sealed class ChangeWeatherRequest : IMessage<ChangeWeatherRequest>, IMessage, IEquatable<ChangeWeatherRequest>, IDeepCloneable<ChangeWeatherRequest>, IBufferMessage
	{
		// Token: 0x060040D7 RID: 16599 RVA: 0x0009F171 File Offset: 0x0009D371
		[NullableContext(1)]
		public static ChangeWeatherRequest Create()
		{
			return new ChangeWeatherRequest();
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0009F178 File Offset: 0x0009D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x0009F17B File Offset: 0x0009D37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeWeatherRequest.Descriptor;
			}
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x0009F182 File Offset: 0x0009D382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest()
		{
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x0009F18A File Offset: 0x0009D38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest(ChangeWeatherRequest other) : this()
		{
			this.weatherId_ = other.weatherId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x0009F1BB File Offset: 0x0009D3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest Clone()
		{
			return new ChangeWeatherRequest(this);
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x0009F1C3 File Offset: 0x0009D3C3
		// (set) Token: 0x060040DE RID: 16606 RVA: 0x0009F1CB File Offset: 0x0009D3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeatherId
		{
			get
			{
				return this.weatherId_;
			}
			set
			{
				this.weatherId_ = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x0009F1D4 File Offset: 0x0009D3D4
		// (set) Token: 0x060040E0 RID: 16608 RVA: 0x0009F1DC File Offset: 0x0009D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x0009F1E5 File Offset: 0x0009D3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeWeatherRequest);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0009F1F3 File Offset: 0x0009D3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeWeatherRequest other)
		{
			return other != null && (other == this || (this.WeatherId == other.WeatherId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0009F234 File Offset: 0x0009D434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeatherId != 0)
			{
				num ^= this.WeatherId.GetHashCode();
			}
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x0009F292 File Offset: 0x0009D492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x0009F29F File Offset: 0x0009D49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0009F2A8 File Offset: 0x0009D4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeatherId);
			}
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0009F304 File Offset: 0x0009D504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeatherId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherId);
			}
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x0009F35C File Offset: 0x0009D55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeWeatherRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeatherId != 0)
			{
				this.WeatherId = other.WeatherId;
			}
			if (other.Reason != ChangeWeatherReason.ClientDefault)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x0009F3AC File Offset: 0x0009D5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0009F3B8 File Offset: 0x0009D5B8
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (ChangeWeatherReason)input.ReadEnum();
					}
				}
				else
				{
					this.WeatherId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D7D RID: 11645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D7E RID: 11646
		public const int WeatherIdFieldNumber = 5;

		// Token: 0x04002D7F RID: 11647
		private int weatherId_;

		// Token: 0x04002D80 RID: 11648
		public const int ReasonFieldNumber = 9;

		// Token: 0x04002D81 RID: 11649
		private ChangeWeatherReason reason_;
	}
}
