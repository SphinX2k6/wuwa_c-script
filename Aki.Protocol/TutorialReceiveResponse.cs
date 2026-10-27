using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001477 RID: 5239
	[NetMessage(EMessageId.TutorialReceiveResponse)]
	public sealed class TutorialReceiveResponse : IMessage<TutorialReceiveResponse>, IMessage, IEquatable<TutorialReceiveResponse>, IDeepCloneable<TutorialReceiveResponse>, IBufferMessage
	{
		// Token: 0x0601BBB2 RID: 113586 RVA: 0x0040328D File Offset: 0x0040148D
		[NullableContext(1)]
		public static TutorialReceiveResponse Create()
		{
			return new TutorialReceiveResponse();
		}

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x0601BBB3 RID: 113587 RVA: 0x00403294 File Offset: 0x00401494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x0601BBB4 RID: 113588 RVA: 0x00403297 File Offset: 0x00401497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601BBB5 RID: 113589 RVA: 0x0040329E File Offset: 0x0040149E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse()
		{
		}

		// Token: 0x0601BBB6 RID: 113590 RVA: 0x004032BC File Offset: 0x004014BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse(TutorialReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBB7 RID: 113591 RVA: 0x0040330E File Offset: 0x0040150E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveResponse Clone()
		{
			return new TutorialReceiveResponse(this);
		}

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x0601BBB8 RID: 113592 RVA: 0x00403316 File Offset: 0x00401516
		// (set) Token: 0x0601BBB9 RID: 113593 RVA: 0x0040331E File Offset: 0x0040151E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x0601BBBA RID: 113594 RVA: 0x00403327 File Offset: 0x00401527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x0601BBBB RID: 113595 RVA: 0x0040332F File Offset: 0x0040152F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601BBBC RID: 113596 RVA: 0x00403337 File Offset: 0x00401537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialReceiveResponse);
		}

		// Token: 0x0601BBBD RID: 113597 RVA: 0x00403348 File Offset: 0x00401548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBBE RID: 113598 RVA: 0x004033AC File Offset: 0x004015AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BBBF RID: 113599 RVA: 0x0040340D File Offset: 0x0040160D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBC0 RID: 113600 RVA: 0x0040341A File Offset: 0x0040161A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBC1 RID: 113601 RVA: 0x00403424 File Offset: 0x00401624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, TutorialReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, TutorialReceiveResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBC2 RID: 113602 RVA: 0x00403484 File Offset: 0x00401684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(TutorialReceiveResponse._repeated_errorParams_codec);
			num += this.itemMap_.CalculateSize(TutorialReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BBC3 RID: 113603 RVA: 0x004034E8 File Offset: 0x004016E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BBC4 RID: 113604 RVA: 0x00403546 File Offset: 0x00401746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBC5 RID: 113605 RVA: 0x00403550 File Offset: 0x00401750
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
					if (num != 96U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, TutorialReceiveResponse._repeated_errorParams_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, TutorialReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04009FAF RID: 40879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FB0 RID: 40880
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009FB1 RID: 40881
		private ErrorCode errorCode_;

		// Token: 0x04009FB2 RID: 40882
		public const int ErrorParamsFieldNumber = 15;

		// Token: 0x04009FB3 RID: 40883
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(122U);

		// Token: 0x04009FB4 RID: 40884
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04009FB5 RID: 40885
		public const int ItemMapFieldNumber = 7;

		// Token: 0x04009FB6 RID: 40886
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04009FB7 RID: 40887
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
