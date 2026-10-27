using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F25 RID: 3877
	[NetMessage(EMessageId.ResetPointEntityNotify)]
	public sealed class ResetPointEntityNotify : IMessage<ResetPointEntityNotify>, IMessage, IEquatable<ResetPointEntityNotify>, IDeepCloneable<ResetPointEntityNotify>, IBufferMessage
	{
		// Token: 0x06014BFC RID: 84988 RVA: 0x00302D9C File Offset: 0x00300F9C
		[NullableContext(1)]
		public static ResetPointEntityNotify Create()
		{
			return new ResetPointEntityNotify();
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x06014BFD RID: 84989 RVA: 0x00302DA3 File Offset: 0x00300FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x06014BFE RID: 84990 RVA: 0x00302DA6 File Offset: 0x00300FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetPointEntityNotify.Descriptor;
			}
		}

		// Token: 0x06014BFF RID: 84991 RVA: 0x00302DAD File Offset: 0x00300FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify()
		{
		}

		// Token: 0x06014C00 RID: 84992 RVA: 0x00302DB5 File Offset: 0x00300FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify(ResetPointEntityNotify other) : this()
		{
			this.resetPointEntityId_ = other.resetPointEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C01 RID: 84993 RVA: 0x00302DDA File Offset: 0x00300FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify Clone()
		{
			return new ResetPointEntityNotify(this);
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x06014C02 RID: 84994 RVA: 0x00302DE2 File Offset: 0x00300FE2
		// (set) Token: 0x06014C03 RID: 84995 RVA: 0x00302DEA File Offset: 0x00300FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetPointEntityId
		{
			get
			{
				return this.resetPointEntityId_;
			}
			set
			{
				this.resetPointEntityId_ = value;
			}
		}

		// Token: 0x06014C04 RID: 84996 RVA: 0x00302DF3 File Offset: 0x00300FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetPointEntityNotify);
		}

		// Token: 0x06014C05 RID: 84997 RVA: 0x00302E01 File Offset: 0x00301001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetPointEntityNotify other)
		{
			return other != null && (other == this || (this.ResetPointEntityId == other.ResetPointEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C06 RID: 84998 RVA: 0x00302E30 File Offset: 0x00301030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResetPointEntityId != 0)
			{
				num ^= this.ResetPointEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C07 RID: 84999 RVA: 0x00302E6F File Offset: 0x0030106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C08 RID: 85000 RVA: 0x00302E7C File Offset: 0x0030107C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C09 RID: 85001 RVA: 0x00302E85 File Offset: 0x00301085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetPointEntityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ResetPointEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C0A RID: 85002 RVA: 0x00302EB8 File Offset: 0x003010B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResetPointEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetPointEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C0B RID: 85003 RVA: 0x00302EF6 File Offset: 0x003010F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetPointEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResetPointEntityId != 0)
			{
				this.ResetPointEntityId = other.ResetPointEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C0C RID: 85004 RVA: 0x00302F27 File Offset: 0x00301127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C0D RID: 85005 RVA: 0x00302F30 File Offset: 0x00301130
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ResetPointEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D50 RID: 32080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D51 RID: 32081
		public const int ResetPointEntityIdFieldNumber = 10;

		// Token: 0x04007D52 RID: 32082
		private int resetPointEntityId_;
	}
}
