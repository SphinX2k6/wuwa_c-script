using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001732 RID: 5938
	[NetMessage(EMessageId.AiInformationRequest)]
	public sealed class AiInformationRequest : IMessage<AiInformationRequest>, IMessage, IEquatable<AiInformationRequest>, IDeepCloneable<AiInformationRequest>, IBufferMessage
	{
		// Token: 0x0601DCD8 RID: 122072 RVA: 0x0045EA9C File Offset: 0x0045CC9C
		[NullableContext(1)]
		public static AiInformationRequest Create()
		{
			return new AiInformationRequest();
		}

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x0601DCD9 RID: 122073 RVA: 0x0045EAA3 File Offset: 0x0045CCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x0601DCDA RID: 122074 RVA: 0x0045EAA6 File Offset: 0x0045CCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationRequest.Descriptor;
			}
		}

		// Token: 0x0601DCDB RID: 122075 RVA: 0x0045EAAD File Offset: 0x0045CCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest()
		{
		}

		// Token: 0x0601DCDC RID: 122076 RVA: 0x0045EAB5 File Offset: 0x0045CCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest(AiInformationRequest other) : this()
		{
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DCDD RID: 122077 RVA: 0x0045EAEA File Offset: 0x0045CCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest Clone()
		{
			return new AiInformationRequest(this);
		}

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x0601DCDE RID: 122078 RVA: 0x0045EAF2 File Offset: 0x0045CCF2
		// (set) Token: 0x0601DCDF RID: 122079 RVA: 0x0045EAFA File Offset: 0x0045CCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x0601DCE0 RID: 122080 RVA: 0x0045EB03 File Offset: 0x0045CD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationRequest);
		}

		// Token: 0x0601DCE1 RID: 122081 RVA: 0x0045EB11 File Offset: 0x0045CD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationRequest other)
		{
			return other != null && (other == this || (object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DCE2 RID: 122082 RVA: 0x0045EB44 File Offset: 0x0045CD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DCE3 RID: 122083 RVA: 0x0045EB80 File Offset: 0x0045CD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DCE4 RID: 122084 RVA: 0x0045EB8D File Offset: 0x0045CD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DCE5 RID: 122085 RVA: 0x0045EB96 File Offset: 0x0045CD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DCE6 RID: 122086 RVA: 0x0045EBC8 File Offset: 0x0045CDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DCE7 RID: 122087 RVA: 0x0045EC08 File Offset: 0x0045CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new AiInformation();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DCE8 RID: 122088 RVA: 0x0045EC5C File Offset: 0x0045CE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DCE9 RID: 122089 RVA: 0x0045EC68 File Offset: 0x0045CE68
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.aiInfo_ == null)
					{
						this.AiInfo = new AiInformation();
					}
					input.ReadMessage(this.AiInfo);
				}
			}
		}

		// Token: 0x0400C98F RID: 51599
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C990 RID: 51600
		public const int AiInfoFieldNumber = 3;

		// Token: 0x0400C991 RID: 51601
		private AiInformation aiInfo_;
	}
}
