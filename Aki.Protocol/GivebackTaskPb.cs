using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F6 RID: 1782
	public sealed class GivebackTaskPb : IMessage<GivebackTaskPb>, IMessage, IEquatable<GivebackTaskPb>, IDeepCloneable<GivebackTaskPb>, IBufferMessage
	{
		// Token: 0x0600A263 RID: 41571 RVA: 0x00188C5D File Offset: 0x00186E5D
		[NullableContext(1)]
		public static GivebackTaskPb Create()
		{
			return new GivebackTaskPb();
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600A264 RID: 41572 RVA: 0x00188C64 File Offset: 0x00186E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackTaskPb> Parser
		{
			get
			{
				return GivebackTaskPb._parser;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600A265 RID: 41573 RVA: 0x00188C6B File Offset: 0x00186E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x00188C6E File Offset: 0x00186E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackTaskPb.Descriptor;
			}
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x00188C75 File Offset: 0x00186E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb()
		{
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x00188C7D File Offset: 0x00186E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb(GivebackTaskPb other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x00188CAE File Offset: 0x00186EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackTaskPb Clone()
		{
			return new GivebackTaskPb(this);
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600A26A RID: 41578 RVA: 0x00188CB6 File Offset: 0x00186EB6
		// (set) Token: 0x0600A26B RID: 41579 RVA: 0x00188CBE File Offset: 0x00186EBE
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

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x00188CC7 File Offset: 0x00186EC7
		// (set) Token: 0x0600A26D RID: 41581 RVA: 0x00188CCF File Offset: 0x00186ECF
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

		// Token: 0x0600A26E RID: 41582 RVA: 0x00188CD8 File Offset: 0x00186ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackTaskPb);
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x00188CE6 File Offset: 0x00186EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackTaskPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x00188D24 File Offset: 0x00186F24
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

		// Token: 0x0600A271 RID: 41585 RVA: 0x00188D7C File Offset: 0x00186F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x00188D89 File Offset: 0x00186F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x00188D94 File Offset: 0x00186F94
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

		// Token: 0x0600A274 RID: 41588 RVA: 0x00188DEC File Offset: 0x00186FEC
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

		// Token: 0x0600A275 RID: 41589 RVA: 0x00188E44 File Offset: 0x00187044
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

		// Token: 0x0600A276 RID: 41590 RVA: 0x00188E94 File Offset: 0x00187094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x00188EA0 File Offset: 0x001870A0
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

		// Token: 0x04004B46 RID: 19270
		private static readonly MessageParser<GivebackTaskPb> _parser = new MessageParser<GivebackTaskPb>(() => new GivebackTaskPb());

		// Token: 0x04004B47 RID: 19271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B48 RID: 19272
		public const int IdFieldNumber = 1;

		// Token: 0x04004B49 RID: 19273
		private int id_;

		// Token: 0x04004B4A RID: 19274
		public const int ScoreFieldNumber = 2;

		// Token: 0x04004B4B RID: 19275
		private int score_;
	}
}
