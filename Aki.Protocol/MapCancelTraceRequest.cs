using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000984 RID: 2436
	[NetMessage(EMessageId.MapCancelTraceRequest)]
	public sealed class MapCancelTraceRequest : IMessage<MapCancelTraceRequest>, IMessage, IEquatable<MapCancelTraceRequest>, IDeepCloneable<MapCancelTraceRequest>, IBufferMessage
	{
		// Token: 0x0600D634 RID: 54836 RVA: 0x001F8079 File Offset: 0x001F6279
		[NullableContext(1)]
		public static MapCancelTraceRequest Create()
		{
			return new MapCancelTraceRequest();
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600D635 RID: 54837 RVA: 0x001F8080 File Offset: 0x001F6280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600D636 RID: 54838 RVA: 0x001F8083 File Offset: 0x001F6283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600D637 RID: 54839 RVA: 0x001F808A File Offset: 0x001F628A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest()
		{
		}

		// Token: 0x0600D638 RID: 54840 RVA: 0x001F8092 File Offset: 0x001F6292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest(MapCancelTraceRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D639 RID: 54841 RVA: 0x001F80B7 File Offset: 0x001F62B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest Clone()
		{
			return new MapCancelTraceRequest(this);
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0600D63A RID: 54842 RVA: 0x001F80BF File Offset: 0x001F62BF
		// (set) Token: 0x0600D63B RID: 54843 RVA: 0x001F80C7 File Offset: 0x001F62C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0600D63C RID: 54844 RVA: 0x001F80D0 File Offset: 0x001F62D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceRequest);
		}

		// Token: 0x0600D63D RID: 54845 RVA: 0x001F80DE File Offset: 0x001F62DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D63E RID: 54846 RVA: 0x001F810C File Offset: 0x001F630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x001F814B File Offset: 0x001F634B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x001F8158 File Offset: 0x001F6358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x001F8161 File Offset: 0x001F6361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x001F8194 File Offset: 0x001F6394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x001F81D2 File Offset: 0x001F63D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCancelTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x001F8203 File Offset: 0x001F6403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x001F820C File Offset: 0x001F640C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400598D RID: 22925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400598E RID: 22926
		public const int MarkIdFieldNumber = 14;

		// Token: 0x0400598F RID: 22927
		private int markId_;
	}
}
