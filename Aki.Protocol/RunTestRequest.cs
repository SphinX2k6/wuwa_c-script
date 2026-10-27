using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113D RID: 4413
	[NetMessage(EMessageId.RunTestRequest)]
	public sealed class RunTestRequest : IMessage<RunTestRequest>, IMessage, IEquatable<RunTestRequest>, IDeepCloneable<RunTestRequest>, IBufferMessage
	{
		// Token: 0x06017886 RID: 96390 RVA: 0x0036AC81 File Offset: 0x00368E81
		[NullableContext(1)]
		public static RunTestRequest Create()
		{
			return new RunTestRequest();
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x06017887 RID: 96391 RVA: 0x0036AC88 File Offset: 0x00368E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06017888 RID: 96392 RVA: 0x0036AC8B File Offset: 0x00368E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTestRequest.Descriptor;
			}
		}

		// Token: 0x06017889 RID: 96393 RVA: 0x0036AC92 File Offset: 0x00368E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest()
		{
		}

		// Token: 0x0601788A RID: 96394 RVA: 0x0036ACB0 File Offset: 0x00368EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest(RunTestRequest other) : this()
		{
			this.type_ = other.type_;
			this.params_ = other.params_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601788B RID: 96395 RVA: 0x0036ACE1 File Offset: 0x00368EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest Clone()
		{
			return new RunTestRequest(this);
		}

		// Token: 0x17004EFC RID: 20220
		// (get) Token: 0x0601788C RID: 96396 RVA: 0x0036ACE9 File Offset: 0x00368EE9
		// (set) Token: 0x0601788D RID: 96397 RVA: 0x0036ACF1 File Offset: 0x00368EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x0601788E RID: 96398 RVA: 0x0036AD04 File Offset: 0x00368F04
		// (set) Token: 0x0601788F RID: 96399 RVA: 0x0036AD0C File Offset: 0x00368F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06017890 RID: 96400 RVA: 0x0036AD1F File Offset: 0x00368F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTestRequest);
		}

		// Token: 0x06017891 RID: 96401 RVA: 0x0036AD30 File Offset: 0x00368F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTestRequest other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.Params != other.Params) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017892 RID: 96402 RVA: 0x0036AD84 File Offset: 0x00368F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type.Length != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Params.Length != 0)
			{
				num ^= this.Params.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017893 RID: 96403 RVA: 0x0036ADE0 File Offset: 0x00368FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017894 RID: 96404 RVA: 0x0036ADED File Offset: 0x00368FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017895 RID: 96405 RVA: 0x0036ADF8 File Offset: 0x00368FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Type);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Params);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017896 RID: 96406 RVA: 0x0036AE5C File Offset: 0x0036905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			if (this.Params.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Params);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017897 RID: 96407 RVA: 0x0036AEBC File Offset: 0x003690BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type.Length != 0)
			{
				this.Type = other.Type;
			}
			if (other.Params.Length != 0)
			{
				this.Params = other.Params;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017898 RID: 96408 RVA: 0x0036AF16 File Offset: 0x00369116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017899 RID: 96409 RVA: 0x0036AF20 File Offset: 0x00369120
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
				if (num != 34U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Params = input.ReadString();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x04008BCD RID: 35789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BCE RID: 35790
		public const int TypeFieldNumber = 4;

		// Token: 0x04008BCF RID: 35791
		private string type_ = "";

		// Token: 0x04008BD0 RID: 35792
		public const int ParamsFieldNumber = 6;

		// Token: 0x04008BD1 RID: 35793
		private string params_ = "";
	}
}
