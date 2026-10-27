using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD2 RID: 3282
	[NetMessage(EMessageId.PhantomFetterRecommendRequest)]
	public sealed class PhantomFetterRecommendRequest : IMessage<PhantomFetterRecommendRequest>, IMessage, IEquatable<PhantomFetterRecommendRequest>, IDeepCloneable<PhantomFetterRecommendRequest>, IBufferMessage
	{
		// Token: 0x06011C3B RID: 72763 RVA: 0x00299746 File Offset: 0x00297946
		[NullableContext(1)]
		public static PhantomFetterRecommendRequest Create()
		{
			return new PhantomFetterRecommendRequest();
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x06011C3C RID: 72764 RVA: 0x0029974D File Offset: 0x0029794D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x06011C3D RID: 72765 RVA: 0x00299750 File Offset: 0x00297950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06011C3E RID: 72766 RVA: 0x00299757 File Offset: 0x00297957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest()
		{
		}

		// Token: 0x06011C3F RID: 72767 RVA: 0x0029975F File Offset: 0x0029795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest(PhantomFetterRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C40 RID: 72768 RVA: 0x00299784 File Offset: 0x00297984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendRequest Clone()
		{
			return new PhantomFetterRecommendRequest(this);
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x06011C41 RID: 72769 RVA: 0x0029978C File Offset: 0x0029798C
		// (set) Token: 0x06011C42 RID: 72770 RVA: 0x00299794 File Offset: 0x00297994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06011C43 RID: 72771 RVA: 0x0029979D File Offset: 0x0029799D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendRequest);
		}

		// Token: 0x06011C44 RID: 72772 RVA: 0x002997AB File Offset: 0x002979AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C45 RID: 72773 RVA: 0x002997DC File Offset: 0x002979DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C46 RID: 72774 RVA: 0x0029981B File Offset: 0x00297A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C47 RID: 72775 RVA: 0x00299828 File Offset: 0x00297A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C48 RID: 72776 RVA: 0x00299831 File Offset: 0x00297A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C49 RID: 72777 RVA: 0x00299864 File Offset: 0x00297A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C4A RID: 72778 RVA: 0x002998A2 File Offset: 0x00297AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C4B RID: 72779 RVA: 0x002998D3 File Offset: 0x00297AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C4C RID: 72780 RVA: 0x002998DC File Offset: 0x00297ADC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F9F RID: 28575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FA0 RID: 28576
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04006FA1 RID: 28577
		private int roleId_;
	}
}
