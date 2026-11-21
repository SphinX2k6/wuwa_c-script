using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001177 RID: 4471
	[NetMessage(EMessageId.RunTestRequest)]
	public sealed class RunTestRequest : IMessage<RunTestRequest>, IMessage, IEquatable<RunTestRequest>, IDeepCloneable<RunTestRequest>, IBufferMessage
	{
		// Token: 0x06017E27 RID: 97831 RVA: 0x00379FCD File Offset: 0x003781CD
		[NullableContext(1)]
		public static RunTestRequest Create()
		{
			return new RunTestRequest();
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x06017E28 RID: 97832 RVA: 0x00379FD4 File Offset: 0x003781D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x06017E29 RID: 97833 RVA: 0x00379FD7 File Offset: 0x003781D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTestRequest.Descriptor;
			}
		}

		// Token: 0x06017E2A RID: 97834 RVA: 0x00379FDE File Offset: 0x003781DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest()
		{
		}

		// Token: 0x06017E2B RID: 97835 RVA: 0x00379FFC File Offset: 0x003781FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest(RunTestRequest other) : this()
		{
			this.type_ = other.type_;
			this.params_ = other.params_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E2C RID: 97836 RVA: 0x0037A02D File Offset: 0x0037822D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestRequest Clone()
		{
			return new RunTestRequest(this);
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x06017E2D RID: 97837 RVA: 0x0037A035 File Offset: 0x00378235
		// (set) Token: 0x06017E2E RID: 97838 RVA: 0x0037A03D File Offset: 0x0037823D
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

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x06017E2F RID: 97839 RVA: 0x0037A050 File Offset: 0x00378250
		// (set) Token: 0x06017E30 RID: 97840 RVA: 0x0037A058 File Offset: 0x00378258
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

		// Token: 0x06017E31 RID: 97841 RVA: 0x0037A06B File Offset: 0x0037826B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTestRequest);
		}

		// Token: 0x06017E32 RID: 97842 RVA: 0x0037A07C File Offset: 0x0037827C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTestRequest other)
		{
			return other != null && (other == this || (!(this.Type != other.Type) && !(this.Params != other.Params) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E33 RID: 97843 RVA: 0x0037A0D0 File Offset: 0x003782D0
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

		// Token: 0x06017E34 RID: 97844 RVA: 0x0037A12C File Offset: 0x0037832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E35 RID: 97845 RVA: 0x0037A139 File Offset: 0x00378339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E36 RID: 97846 RVA: 0x0037A144 File Offset: 0x00378344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Type);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Params);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E37 RID: 97847 RVA: 0x0037A1A8 File Offset: 0x003783A8
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

		// Token: 0x06017E38 RID: 97848 RVA: 0x0037A208 File Offset: 0x00378408
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

		// Token: 0x06017E39 RID: 97849 RVA: 0x0037A262 File Offset: 0x00378462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E3A RID: 97850 RVA: 0x0037A26C File Offset: 0x0037846C
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
				if (num != 18U)
				{
					if (num != 66U)
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

		// Token: 0x04008E60 RID: 36448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E61 RID: 36449
		public const int TypeFieldNumber = 2;

		// Token: 0x04008E62 RID: 36450
		private string type_ = "";

		// Token: 0x04008E63 RID: 36451
		public const int ParamsFieldNumber = 8;

		// Token: 0x04008E64 RID: 36452
		private string params_ = "";
	}
}
