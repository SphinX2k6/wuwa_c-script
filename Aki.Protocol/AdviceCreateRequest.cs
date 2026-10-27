using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C7 RID: 199
	[NetMessage(EMessageId.AdviceCreateRequest)]
	public sealed class AdviceCreateRequest : IMessage<AdviceCreateRequest>, IMessage, IEquatable<AdviceCreateRequest>, IDeepCloneable<AdviceCreateRequest>, IBufferMessage
	{
		// Token: 0x06001F53 RID: 8019 RVA: 0x0005541F File Offset: 0x0005361F
		[NullableContext(1)]
		public static AdviceCreateRequest Create()
		{
			return new AdviceCreateRequest();
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00055426 File Offset: 0x00053626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00055429 File Offset: 0x00053629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceCreateRequest.Descriptor;
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00055430 File Offset: 0x00053630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest()
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00055444 File Offset: 0x00053644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest(AdviceCreateRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000554B1 File Offset: 0x000536B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest Clone()
		{
			return new AdviceCreateRequest(this);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x000554B9 File Offset: 0x000536B9
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x000554C1 File Offset: 0x000536C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x000554CA File Offset: 0x000536CA
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x000554D2 File Offset: 0x000536D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x000554DB File Offset: 0x000536DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000554E3 File Offset: 0x000536E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceCreateRequest);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000554F4 File Offset: 0x000536F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceCreateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0005555C File Offset: 0x0005375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000555BC File Offset: 0x000537BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000555C9 File Offset: 0x000537C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000555D4 File Offset: 0x000537D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contents_.WriteTo(ref output, AdviceCreateRequest._repeated_contents_codec);
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00055640 File Offset: 0x00053840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			num += this.contents_.CalculateSize(AdviceCreateRequest._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000556AC File Offset: 0x000538AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceCreateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			this.contents_.Add(other.contents_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0005573D File Offset: 0x0005393D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00055748 File Offset: 0x00053948
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
				if (num != 10U)
				{
					if (num != 34U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rot_ == null)
							{
								this.Rot = new Rotator();
							}
							input.ReadMessage(this.Rot);
						}
					}
					else
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
					}
				}
				else
				{
					this.contents_.AddEntriesFrom(ref input, AdviceCreateRequest._repeated_contents_codec);
				}
			}
		}

		// Token: 0x040023B3 RID: 9139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023B4 RID: 9140
		public const int PosFieldNumber = 4;

		// Token: 0x040023B5 RID: 9141
		private Vector pos_;

		// Token: 0x040023B6 RID: 9142
		public const int RotFieldNumber = 14;

		// Token: 0x040023B7 RID: 9143
		private Rotator rot_;

		// Token: 0x040023B8 RID: 9144
		public const int ContentsFieldNumber = 1;

		// Token: 0x040023B9 RID: 9145
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(10U, PbAdviceContent.Parser);

		// Token: 0x040023BA RID: 9146
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
