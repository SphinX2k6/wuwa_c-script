using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CA RID: 4554
	[NetMessage(EMessageId.SceneSubLevelsRequest)]
	public sealed class SceneSubLevelsRequest : IMessage<SceneSubLevelsRequest>, IMessage, IEquatable<SceneSubLevelsRequest>, IDeepCloneable<SceneSubLevelsRequest>, IBufferMessage
	{
		// Token: 0x0601850A RID: 99594 RVA: 0x0038A2CC File Offset: 0x003884CC
		[NullableContext(1)]
		public static SceneSubLevelsRequest Create()
		{
			return new SceneSubLevelsRequest();
		}

		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x0601850B RID: 99595 RVA: 0x0038A2D3 File Offset: 0x003884D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x0601850C RID: 99596 RVA: 0x0038A2D6 File Offset: 0x003884D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsRequest.Descriptor;
			}
		}

		// Token: 0x0601850D RID: 99597 RVA: 0x0038A2DD File Offset: 0x003884DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest()
		{
		}

		// Token: 0x0601850E RID: 99598 RVA: 0x0038A2FB File Offset: 0x003884FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest(SceneSubLevelsRequest other) : this()
		{
			this.showSubLevels_ = other.showSubLevels_.Clone();
			this.hideSubLevels_ = other.hideSubLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601850F RID: 99599 RVA: 0x0038A336 File Offset: 0x00388536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsRequest Clone()
		{
			return new SceneSubLevelsRequest(this);
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x06018510 RID: 99600 RVA: 0x0038A33E File Offset: 0x0038853E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ShowSubLevels
		{
			get
			{
				return this.showSubLevels_;
			}
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x06018511 RID: 99601 RVA: 0x0038A346 File Offset: 0x00388546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x06018512 RID: 99602 RVA: 0x0038A34E File Offset: 0x0038854E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsRequest);
		}

		// Token: 0x06018513 RID: 99603 RVA: 0x0038A35C File Offset: 0x0038855C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsRequest other)
		{
			return other != null && (other == this || (this.showSubLevels_.Equals(other.showSubLevels_) && this.hideSubLevels_.Equals(other.hideSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018514 RID: 99604 RVA: 0x0038A3B0 File Offset: 0x003885B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.showSubLevels_.GetHashCode();
			num ^= this.hideSubLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018515 RID: 99605 RVA: 0x0038A3F2 File Offset: 0x003885F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018516 RID: 99606 RVA: 0x0038A3FF File Offset: 0x003885FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018517 RID: 99607 RVA: 0x0038A408 File Offset: 0x00388608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hideSubLevels_.WriteTo(ref output, SceneSubLevelsRequest._repeated_hideSubLevels_codec);
			this.showSubLevels_.WriteTo(ref output, SceneSubLevelsRequest._repeated_showSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018518 RID: 99608 RVA: 0x0038A440 File Offset: 0x00388640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.showSubLevels_.CalculateSize(SceneSubLevelsRequest._repeated_showSubLevels_codec);
			num += this.hideSubLevels_.CalculateSize(SceneSubLevelsRequest._repeated_hideSubLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018519 RID: 99609 RVA: 0x0038A48C File Offset: 0x0038868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSubLevelsRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.showSubLevels_.Add(other.showSubLevels_);
			this.hideSubLevels_.Add(other.hideSubLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601851A RID: 99610 RVA: 0x0038A4CB File Offset: 0x003886CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601851B RID: 99611 RVA: 0x0038A4D4 File Offset: 0x003886D4
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
				if (num != 66U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.showSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsRequest._repeated_showSubLevels_codec);
					}
				}
				else
				{
					this.hideSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsRequest._repeated_hideSubLevels_codec);
				}
			}
		}

		// Token: 0x0400908B RID: 37003
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400908C RID: 37004
		public const int ShowSubLevelsFieldNumber = 9;

		// Token: 0x0400908D RID: 37005
		private static readonly FieldCodec<string> _repeated_showSubLevels_codec = FieldCodec.ForString(74U);

		// Token: 0x0400908E RID: 37006
		private readonly RepeatedField<string> showSubLevels_ = new RepeatedField<string>();

		// Token: 0x0400908F RID: 37007
		public const int HideSubLevelsFieldNumber = 8;

		// Token: 0x04009090 RID: 37008
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(66U);

		// Token: 0x04009091 RID: 37009
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();
	}
}
