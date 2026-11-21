using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C8 RID: 200
	[NetMessage(EMessageId.AdviceCreateRequest)]
	public sealed class AdviceCreateRequest : IMessage<AdviceCreateRequest>, IMessage, IEquatable<AdviceCreateRequest>, IDeepCloneable<AdviceCreateRequest>, IBufferMessage
	{
		// Token: 0x06001F9C RID: 8092 RVA: 0x000560D4 File Offset: 0x000542D4
		[NullableContext(1)]
		public static AdviceCreateRequest Create()
		{
			return new AdviceCreateRequest();
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000560DB File Offset: 0x000542DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000560DE File Offset: 0x000542DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceCreateRequest.Descriptor;
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000560E5 File Offset: 0x000542E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest()
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x000560F8 File Offset: 0x000542F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest(AdviceCreateRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00056165 File Offset: 0x00054365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateRequest Clone()
		{
			return new AdviceCreateRequest(this);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0005616D File Offset: 0x0005436D
		// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x00056175 File Offset: 0x00054375
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0005617E File Offset: 0x0005437E
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x00056186 File Offset: 0x00054386
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

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0005618F File Offset: 0x0005438F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00056197 File Offset: 0x00054397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceCreateRequest);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000561A8 File Offset: 0x000543A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceCreateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00056210 File Offset: 0x00054410
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

		// Token: 0x06001FAA RID: 8106 RVA: 0x00056270 File Offset: 0x00054470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0005627D File Offset: 0x0005447D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00056288 File Offset: 0x00054488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contents_.WriteTo(ref output, AdviceCreateRequest._repeated_contents_codec);
			if (this.pos_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000562F4 File Offset: 0x000544F4
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

		// Token: 0x06001FAE RID: 8110 RVA: 0x00056360 File Offset: 0x00054560
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

		// Token: 0x06001FAF RID: 8111 RVA: 0x000563F1 File Offset: 0x000545F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000563FC File Offset: 0x000545FC
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
				if (num != 90U)
				{
					if (num != 106U)
					{
						if (num != 122U)
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

		// Token: 0x04002416 RID: 9238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002417 RID: 9239
		public const int PosFieldNumber = 13;

		// Token: 0x04002418 RID: 9240
		private Vector pos_;

		// Token: 0x04002419 RID: 9241
		public const int RotFieldNumber = 15;

		// Token: 0x0400241A RID: 9242
		private Rotator rot_;

		// Token: 0x0400241B RID: 9243
		public const int ContentsFieldNumber = 11;

		// Token: 0x0400241C RID: 9244
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(90U, PbAdviceContent.Parser);

		// Token: 0x0400241D RID: 9245
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
