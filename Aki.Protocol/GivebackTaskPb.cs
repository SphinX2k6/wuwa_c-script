using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E2 RID: 1762
	public sealed class GivebackTaskPb : IMessage<GivebackTaskPb>, IMessage, IEquatable<GivebackTaskPb>, IDeepCloneable<GivebackTaskPb>, IBufferMessage
	{
		// Token: 0x0600A10D RID: 41229 RVA: 0x00186229 File Offset: 0x00184429
		[NullableContext(1)]
		public static GivebackTaskPb Create()
		{
			return new GivebackTaskPb();
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x00186230 File Offset: 0x00184430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackTaskPb> Parser
		{
			get
			{
				return GivebackTaskPb._parser;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600A10F RID: 41231 RVA: 0x00186237 File Offset: 0x00184437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x0018623A File Offset: 0x0018443A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackTaskPb.Descriptor;
			}
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x00186241 File Offset: 0x00184441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb()
		{
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x00186249 File Offset: 0x00184449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb(GivebackTaskPb other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x0018627A File Offset: 0x0018447A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb Clone()
		{
			return new GivebackTaskPb(this);
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x00186282 File Offset: 0x00184482
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x0018628A File Offset: 0x0018448A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x00186293 File Offset: 0x00184493
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x0018629B File Offset: 0x0018449B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x001862A4 File Offset: 0x001844A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackTaskPb);
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x001862B2 File Offset: 0x001844B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackTaskPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x001862F0 File Offset: 0x001844F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x00186348 File Offset: 0x00184548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x00186355 File Offset: 0x00184555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x00186360 File Offset: 0x00184560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x001863B8 File Offset: 0x001845B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x00186410 File Offset: 0x00184610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x00186460 File Offset: 0x00184660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x0018646C File Offset: 0x0018466C
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B3F RID: 19263
		private static readonly MessageParser<GivebackTaskPb> _parser = new MessageParser<GivebackTaskPb>(() => new GivebackTaskPb());

		// Token: 0x04004B40 RID: 19264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B41 RID: 19265
		public const int IdFieldNumber = 1;

		// Token: 0x04004B42 RID: 19266
		private int id_;

		// Token: 0x04004B43 RID: 19267
		public const int ScoreFieldNumber = 2;

		// Token: 0x04004B44 RID: 19268
		private int score_;
	}
}
