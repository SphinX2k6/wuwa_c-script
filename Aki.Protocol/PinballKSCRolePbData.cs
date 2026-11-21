using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D40 RID: 3392
	public sealed class PinballKSCRolePbData : IMessage<PinballKSCRolePbData>, IMessage, IEquatable<PinballKSCRolePbData>, IDeepCloneable<PinballKSCRolePbData>, IBufferMessage
	{
		// Token: 0x06012526 RID: 75046 RVA: 0x002ACF73 File Offset: 0x002AB173
		[NullableContext(1)]
		public static PinballKSCRolePbData Create()
		{
			return new PinballKSCRolePbData();
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x06012527 RID: 75047 RVA: 0x002ACF7A File Offset: 0x002AB17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x06012528 RID: 75048 RVA: 0x002ACF7D File Offset: 0x002AB17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballKSCRolePbData.Descriptor;
			}
		}

		// Token: 0x06012529 RID: 75049 RVA: 0x002ACF84 File Offset: 0x002AB184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData()
		{
		}

		// Token: 0x0601252A RID: 75050 RVA: 0x002ACF8C File Offset: 0x002AB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData(PinballKSCRolePbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601252B RID: 75051 RVA: 0x002ACFA5 File Offset: 0x002AB1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData Clone()
		{
			return new PinballKSCRolePbData(this);
		}

		// Token: 0x0601252C RID: 75052 RVA: 0x002ACFAD File Offset: 0x002AB1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballKSCRolePbData);
		}

		// Token: 0x0601252D RID: 75053 RVA: 0x002ACFBB File Offset: 0x002AB1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballKSCRolePbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601252E RID: 75054 RVA: 0x002ACFDC File Offset: 0x002AB1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601252F RID: 75055 RVA: 0x002AD002 File Offset: 0x002AB202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012530 RID: 75056 RVA: 0x002AD00F File Offset: 0x002AB20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012531 RID: 75057 RVA: 0x002AD018 File Offset: 0x002AB218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012532 RID: 75058 RVA: 0x002AD030 File Offset: 0x002AB230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012533 RID: 75059 RVA: 0x002AD056 File Offset: 0x002AB256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballKSCRolePbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012534 RID: 75060 RVA: 0x002AD073 File Offset: 0x002AB273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012535 RID: 75061 RVA: 0x002AD07C File Offset: 0x002AB27C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007295 RID: 29333
		private UnknownFieldSet _unknownFields;
	}
}
