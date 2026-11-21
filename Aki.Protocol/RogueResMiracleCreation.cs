using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE4 RID: 4068
	public sealed class RogueResMiracleCreation : IMessage<RogueResMiracleCreation>, IMessage, IEquatable<RogueResMiracleCreation>, IDeepCloneable<RogueResMiracleCreation>, IBufferMessage
	{
		// Token: 0x06015C63 RID: 89187 RVA: 0x0032A494 File Offset: 0x00328694
		[NullableContext(1)]
		public static RogueResMiracleCreation Create()
		{
			return new RogueResMiracleCreation();
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06015C64 RID: 89188 RVA: 0x0032A49B File Offset: 0x0032869B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06015C65 RID: 89189 RVA: 0x0032A49E File Offset: 0x0032869E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMiracleCreation.Descriptor;
			}
		}

		// Token: 0x06015C66 RID: 89190 RVA: 0x0032A4A5 File Offset: 0x003286A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation()
		{
		}

		// Token: 0x06015C67 RID: 89191 RVA: 0x0032A4AD File Offset: 0x003286AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation(RogueResMiracleCreation other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C68 RID: 89192 RVA: 0x0032A4DE File Offset: 0x003286DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation Clone()
		{
			return new RogueResMiracleCreation(this);
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x06015C69 RID: 89193 RVA: 0x0032A4E6 File Offset: 0x003286E6
		// (set) Token: 0x06015C6A RID: 89194 RVA: 0x0032A4EE File Offset: 0x003286EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x06015C6B RID: 89195 RVA: 0x0032A4F7 File Offset: 0x003286F7
		// (set) Token: 0x06015C6C RID: 89196 RVA: 0x0032A4FF File Offset: 0x003286FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06015C6D RID: 89197 RVA: 0x0032A508 File Offset: 0x00328708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMiracleCreation);
		}

		// Token: 0x06015C6E RID: 89198 RVA: 0x0032A516 File Offset: 0x00328716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMiracleCreation other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C6F RID: 89199 RVA: 0x0032A554 File Offset: 0x00328754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C70 RID: 89200 RVA: 0x0032A5AC File Offset: 0x003287AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C71 RID: 89201 RVA: 0x0032A5B9 File Offset: 0x003287B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C72 RID: 89202 RVA: 0x0032A5C4 File Offset: 0x003287C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C73 RID: 89203 RVA: 0x0032A61C File Offset: 0x0032881C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C74 RID: 89204 RVA: 0x0032A668 File Offset: 0x00328868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMiracleCreation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C75 RID: 89205 RVA: 0x0032A6B8 File Offset: 0x003288B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C76 RID: 89206 RVA: 0x0032A6C4 File Offset: 0x003288C4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008325 RID: 33573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008326 RID: 33574
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008327 RID: 33575
		private int configId_;

		// Token: 0x04008328 RID: 33576
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008329 RID: 33577
		private bool isNew_;
	}
}
