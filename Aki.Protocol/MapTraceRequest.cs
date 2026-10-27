using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099B RID: 2459
	[NetMessage(EMessageId.MapTraceRequest)]
	public sealed class MapTraceRequest : IMessage<MapTraceRequest>, IMessage, IEquatable<MapTraceRequest>, IDeepCloneable<MapTraceRequest>, IBufferMessage
	{
		// Token: 0x0600D800 RID: 55296 RVA: 0x001FBF39 File Offset: 0x001FA139
		[NullableContext(1)]
		public static MapTraceRequest Create()
		{
			return new MapTraceRequest();
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600D801 RID: 55297 RVA: 0x001FBF40 File Offset: 0x001FA140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x001FBF43 File Offset: 0x001FA143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600D803 RID: 55299 RVA: 0x001FBF4A File Offset: 0x001FA14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest()
		{
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x001FBF52 File Offset: 0x001FA152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest(MapTraceRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x001FBF77 File Offset: 0x001FA177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest Clone()
		{
			return new MapTraceRequest(this);
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0600D806 RID: 55302 RVA: 0x001FBF7F File Offset: 0x001FA17F
		// (set) Token: 0x0600D807 RID: 55303 RVA: 0x001FBF87 File Offset: 0x001FA187
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

		// Token: 0x0600D808 RID: 55304 RVA: 0x001FBF90 File Offset: 0x001FA190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceRequest);
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x001FBF9E File Offset: 0x001FA19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x001FBFCC File Offset: 0x001FA1CC
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

		// Token: 0x0600D80B RID: 55307 RVA: 0x001FC00B File Offset: 0x001FA20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x001FC018 File Offset: 0x001FA218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x001FC021 File Offset: 0x001FA221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x001FC054 File Offset: 0x001FA254
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

		// Token: 0x0600D80F RID: 55311 RVA: 0x001FC092 File Offset: 0x001FA292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceRequest other)
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

		// Token: 0x0600D810 RID: 55312 RVA: 0x001FC0C3 File Offset: 0x001FA2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x001FC0CC File Offset: 0x001FA2CC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A10 RID: 23056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A11 RID: 23057
		public const int MarkIdFieldNumber = 9;

		// Token: 0x04005A12 RID: 23058
		private int markId_;
	}
}
