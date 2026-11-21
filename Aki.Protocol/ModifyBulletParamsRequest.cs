using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D8 RID: 2520
	[NetMessage(EMessageId.ModifyBulletParamsRequest)]
	public sealed class ModifyBulletParamsRequest : IMessage<ModifyBulletParamsRequest>, IMessage, IEquatable<ModifyBulletParamsRequest>, IDeepCloneable<ModifyBulletParamsRequest>, IBufferMessage
	{
		// Token: 0x0600DD2B RID: 56619 RVA: 0x00207808 File Offset: 0x00205A08
		[NullableContext(1)]
		public static ModifyBulletParamsRequest Create()
		{
			return new ModifyBulletParamsRequest();
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x0020780F File Offset: 0x00205A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600DD2D RID: 56621 RVA: 0x00207812 File Offset: 0x00205A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsRequest.Descriptor;
			}
		}

		// Token: 0x0600DD2E RID: 56622 RVA: 0x00207819 File Offset: 0x00205A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest()
		{
		}

		// Token: 0x0600DD2F RID: 56623 RVA: 0x00207821 File Offset: 0x00205A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest(ModifyBulletParamsRequest other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD30 RID: 56624 RVA: 0x00207856 File Offset: 0x00205A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest Clone()
		{
			return new ModifyBulletParamsRequest(this);
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600DD31 RID: 56625 RVA: 0x0020785E File Offset: 0x00205A5E
		// (set) Token: 0x0600DD32 RID: 56626 RVA: 0x00207866 File Offset: 0x00205A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams ModifyBulletParams
		{
			get
			{
				return this.modifyBulletParams_;
			}
			set
			{
				this.modifyBulletParams_ = value;
			}
		}

		// Token: 0x0600DD33 RID: 56627 RVA: 0x0020786F File Offset: 0x00205A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsRequest);
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x0020787D File Offset: 0x00205A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x002078B0 File Offset: 0x00205AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifyBulletParams_ != null)
			{
				num ^= this.ModifyBulletParams.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x002078EC File Offset: 0x00205AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x002078F9 File Offset: 0x00205AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x00207902 File Offset: 0x00205B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x00207934 File Offset: 0x00205B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifyBulletParams_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x00207974 File Offset: 0x00205B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifyBulletParams_ != null)
			{
				if (this.modifyBulletParams_ == null)
				{
					this.ModifyBulletParams = new ModifyBulletParams();
				}
				this.ModifyBulletParams.MergeFrom(other.ModifyBulletParams);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x002079C8 File Offset: 0x00205BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x002079D4 File Offset: 0x00205BD4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.modifyBulletParams_ == null)
					{
						this.ModifyBulletParams = new ModifyBulletParams();
					}
					input.ReadMessage(this.ModifyBulletParams);
				}
			}
		}

		// Token: 0x04005BD6 RID: 23510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD7 RID: 23511
		public const int ModifyBulletParamsFieldNumber = 11;

		// Token: 0x04005BD8 RID: 23512
		private ModifyBulletParams modifyBulletParams_;
	}
}
