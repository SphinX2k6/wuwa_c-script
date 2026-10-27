using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AB RID: 4267
	[NetMessage(EMessageId.RoleShowListUpdateNotify)]
	public sealed class RoleShowListUpdateNotify : IMessage<RoleShowListUpdateNotify>, IMessage, IEquatable<RoleShowListUpdateNotify>, IDeepCloneable<RoleShowListUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016C91 RID: 93329 RVA: 0x0034F95F File Offset: 0x0034DB5F
		[NullableContext(1)]
		public static RoleShowListUpdateNotify Create()
		{
			return new RoleShowListUpdateNotify();
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x06016C92 RID: 93330 RVA: 0x0034F966 File Offset: 0x0034DB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x06016C93 RID: 93331 RVA: 0x0034F969 File Offset: 0x0034DB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016C94 RID: 93332 RVA: 0x0034F970 File Offset: 0x0034DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify()
		{
		}

		// Token: 0x06016C95 RID: 93333 RVA: 0x0034F983 File Offset: 0x0034DB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify(RoleShowListUpdateNotify other) : this()
		{
			this.roleShowList_ = other.roleShowList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C96 RID: 93334 RVA: 0x0034F9AD File Offset: 0x0034DBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify Clone()
		{
			return new RoleShowListUpdateNotify(this);
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x06016C97 RID: 93335 RVA: 0x0034F9B5 File Offset: 0x0034DBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x06016C98 RID: 93336 RVA: 0x0034F9BD File Offset: 0x0034DBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateNotify);
		}

		// Token: 0x06016C99 RID: 93337 RVA: 0x0034F9CB File Offset: 0x0034DBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateNotify other)
		{
			return other != null && (other == this || (this.roleShowList_.Equals(other.roleShowList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x0034FA00 File Offset: 0x0034DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleShowList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C9B RID: 93339 RVA: 0x0034FA34 File Offset: 0x0034DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C9C RID: 93340 RVA: 0x0034FA41 File Offset: 0x0034DC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C9D RID: 93341 RVA: 0x0034FA4A File Offset: 0x0034DC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleShowList_.WriteTo(ref output, RoleShowListUpdateNotify._repeated_roleShowList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C9E RID: 93342 RVA: 0x0034FA74 File Offset: 0x0034DC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleShowList_.CalculateSize(RoleShowListUpdateNotify._repeated_roleShowList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C9F RID: 93343 RVA: 0x0034FAAD File Offset: 0x0034DCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowListUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleShowList_.Add(other.roleShowList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016CA0 RID: 93344 RVA: 0x0034FADB File Offset: 0x0034DCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CA1 RID: 93345 RVA: 0x0034FAE4 File Offset: 0x0034DCE4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleShowList_.AddEntriesFrom(ref input, RoleShowListUpdateNotify._repeated_roleShowList_codec);
				}
			}
		}

		// Token: 0x04008808 RID: 34824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008809 RID: 34825
		public const int RoleShowListFieldNumber = 7;

		// Token: 0x0400880A RID: 34826
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(58U, RoleShowEntry.Parser);

		// Token: 0x0400880B RID: 34827
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();
	}
}
