using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E9 RID: 2537
	[NetMessage(EMessageId.ModifyBulletParamsRequest)]
	public sealed class ModifyBulletParamsRequest : IMessage<ModifyBulletParamsRequest>, IMessage, IEquatable<ModifyBulletParamsRequest>, IDeepCloneable<ModifyBulletParamsRequest>, IBufferMessage
	{
		// Token: 0x0600DE45 RID: 56901 RVA: 0x002099F4 File Offset: 0x00207BF4
		[NullableContext(1)]
		public static ModifyBulletParamsRequest Create()
		{
			return new ModifyBulletParamsRequest();
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0600DE46 RID: 56902 RVA: 0x002099FB File Offset: 0x00207BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x002099FE File Offset: 0x00207BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsRequest.Descriptor;
			}
		}

		// Token: 0x0600DE48 RID: 56904 RVA: 0x00209A05 File Offset: 0x00207C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest()
		{
		}

		// Token: 0x0600DE49 RID: 56905 RVA: 0x00209A0D File Offset: 0x00207C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest(ModifyBulletParamsRequest other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x00209A42 File Offset: 0x00207C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsRequest Clone()
		{
			return new ModifyBulletParamsRequest(this);
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x00209A4A File Offset: 0x00207C4A
		// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x00209A52 File Offset: 0x00207C52
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

		// Token: 0x0600DE4D RID: 56909 RVA: 0x00209A5B File Offset: 0x00207C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsRequest);
		}

		// Token: 0x0600DE4E RID: 56910 RVA: 0x00209A69 File Offset: 0x00207C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x00209A9C File Offset: 0x00207C9C
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

		// Token: 0x0600DE50 RID: 56912 RVA: 0x00209AD8 File Offset: 0x00207CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE51 RID: 56913 RVA: 0x00209AE5 File Offset: 0x00207CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE52 RID: 56914 RVA: 0x00209AEE File Offset: 0x00207CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE53 RID: 56915 RVA: 0x00209B20 File Offset: 0x00207D20
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

		// Token: 0x0600DE54 RID: 56916 RVA: 0x00209B60 File Offset: 0x00207D60
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

		// Token: 0x0600DE55 RID: 56917 RVA: 0x00209BB4 File Offset: 0x00207DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE56 RID: 56918 RVA: 0x00209BC0 File Offset: 0x00207DC0
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

		// Token: 0x04005BCD RID: 23501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BCE RID: 23502
		public const int ModifyBulletParamsFieldNumber = 4;

		// Token: 0x04005BCF RID: 23503
		private ModifyBulletParams modifyBulletParams_;
	}
}
