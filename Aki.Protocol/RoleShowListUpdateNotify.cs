using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109B RID: 4251
	[NetMessage(EMessageId.RoleShowListUpdateNotify)]
	public sealed class RoleShowListUpdateNotify : IMessage<RoleShowListUpdateNotify>, IMessage, IEquatable<RoleShowListUpdateNotify>, IDeepCloneable<RoleShowListUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016BAC RID: 93100 RVA: 0x0034E283 File Offset: 0x0034C483
		[NullableContext(1)]
		public static RoleShowListUpdateNotify Create()
		{
			return new RoleShowListUpdateNotify();
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x06016BAD RID: 93101 RVA: 0x0034E28A File Offset: 0x0034C48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x06016BAE RID: 93102 RVA: 0x0034E28D File Offset: 0x0034C48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016BAF RID: 93103 RVA: 0x0034E294 File Offset: 0x0034C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify()
		{
		}

		// Token: 0x06016BB0 RID: 93104 RVA: 0x0034E2A7 File Offset: 0x0034C4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify(RoleShowListUpdateNotify other) : this()
		{
			this.roleShowList_ = other.roleShowList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BB1 RID: 93105 RVA: 0x0034E2D1 File Offset: 0x0034C4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateNotify Clone()
		{
			return new RoleShowListUpdateNotify(this);
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x06016BB2 RID: 93106 RVA: 0x0034E2D9 File Offset: 0x0034C4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleShowEntry> RoleShowList
		{
			get
			{
				return this.roleShowList_;
			}
		}

		// Token: 0x06016BB3 RID: 93107 RVA: 0x0034E2E1 File Offset: 0x0034C4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateNotify);
		}

		// Token: 0x06016BB4 RID: 93108 RVA: 0x0034E2EF File Offset: 0x0034C4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateNotify other)
		{
			return other != null && (other == this || (this.roleShowList_.Equals(other.roleShowList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BB5 RID: 93109 RVA: 0x0034E324 File Offset: 0x0034C524
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

		// Token: 0x06016BB6 RID: 93110 RVA: 0x0034E358 File Offset: 0x0034C558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BB7 RID: 93111 RVA: 0x0034E365 File Offset: 0x0034C565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BB8 RID: 93112 RVA: 0x0034E36E File Offset: 0x0034C56E
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

		// Token: 0x06016BB9 RID: 93113 RVA: 0x0034E398 File Offset: 0x0034C598
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

		// Token: 0x06016BBA RID: 93114 RVA: 0x0034E3D1 File Offset: 0x0034C5D1
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

		// Token: 0x06016BBB RID: 93115 RVA: 0x0034E3FF File Offset: 0x0034C5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BBC RID: 93116 RVA: 0x0034E408 File Offset: 0x0034C608
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

		// Token: 0x04008832 RID: 34866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008833 RID: 34867
		public const int RoleShowListFieldNumber = 7;

		// Token: 0x04008834 RID: 34868
		private static readonly FieldCodec<RoleShowEntry> _repeated_roleShowList_codec = FieldCodec.ForMessage<RoleShowEntry>(58U, RoleShowEntry.Parser);

		// Token: 0x04008835 RID: 34869
		private readonly RepeatedField<RoleShowEntry> roleShowList_ = new RepeatedField<RoleShowEntry>();
	}
}
