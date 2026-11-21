using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A0 RID: 2464
	[NetMessage(EMessageId.MatchChangeReadyRequest)]
	public sealed class MatchChangeReadyRequest : IMessage<MatchChangeReadyRequest>, IMessage, IEquatable<MatchChangeReadyRequest>, IDeepCloneable<MatchChangeReadyRequest>, IBufferMessage
	{
		// Token: 0x0600D8AB RID: 55467 RVA: 0x001FD9FF File Offset: 0x001FBBFF
		[NullableContext(1)]
		public static MatchChangeReadyRequest Create()
		{
			return new MatchChangeReadyRequest();
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0600D8AC RID: 55468 RVA: 0x001FDA06 File Offset: 0x001FBC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x001FDA09 File Offset: 0x001FBC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyRequest.Descriptor;
			}
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x001FDA10 File Offset: 0x001FBC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest()
		{
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x001FDA18 File Offset: 0x001FBC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest(MatchChangeReadyRequest other) : this()
		{
			this.isReady_ = other.isReady_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x001FDA3D File Offset: 0x001FBC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyRequest Clone()
		{
			return new MatchChangeReadyRequest(this);
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0600D8B1 RID: 55473 RVA: 0x001FDA45 File Offset: 0x001FBC45
		// (set) Token: 0x0600D8B2 RID: 55474 RVA: 0x001FDA4D File Offset: 0x001FBC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			get
			{
				return this.isReady_;
			}
			set
			{
				this.isReady_ = value;
			}
		}

		// Token: 0x0600D8B3 RID: 55475 RVA: 0x001FDA56 File Offset: 0x001FBC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyRequest);
		}

		// Token: 0x0600D8B4 RID: 55476 RVA: 0x001FDA64 File Offset: 0x001FBC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyRequest other)
		{
			return other != null && (other == this || (this.IsReady == other.IsReady && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8B5 RID: 55477 RVA: 0x001FDA94 File Offset: 0x001FBC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsReady)
			{
				num ^= this.IsReady.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D8B6 RID: 55478 RVA: 0x001FDAD3 File Offset: 0x001FBCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8B7 RID: 55479 RVA: 0x001FDAE0 File Offset: 0x001FBCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8B8 RID: 55480 RVA: 0x001FDAE9 File Offset: 0x001FBCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReady)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsReady);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8B9 RID: 55481 RVA: 0x001FDB1C File Offset: 0x001FBD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsReady)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D8BA RID: 55482 RVA: 0x001FDB4E File Offset: 0x001FBD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeReadyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsReady)
			{
				this.IsReady = other.IsReady;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8BB RID: 55483 RVA: 0x001FDB7F File Offset: 0x001FBD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8BC RID: 55484 RVA: 0x001FDB88 File Offset: 0x001FBD88
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsReady = input.ReadBool();
				}
			}
		}

		// Token: 0x04005A93 RID: 23187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A94 RID: 23188
		public const int IsReadyFieldNumber = 15;

		// Token: 0x04005A95 RID: 23189
		private bool isReady_;
	}
}
