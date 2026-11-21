using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149A RID: 5274
	[NetMessage(EMessageId.TrapDefenseGetRewardRequest)]
	public sealed class TrapDefenseGetRewardRequest : IMessage<TrapDefenseGetRewardRequest>, IMessage, IEquatable<TrapDefenseGetRewardRequest>, IDeepCloneable<TrapDefenseGetRewardRequest>, IBufferMessage
	{
		// Token: 0x0601BFFC RID: 114684 RVA: 0x004112BB File Offset: 0x0040F4BB
		[NullableContext(1)]
		public static TrapDefenseGetRewardRequest Create()
		{
			return new TrapDefenseGetRewardRequest();
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x0601BFFD RID: 114685 RVA: 0x004112C2 File Offset: 0x0040F4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x0601BFFE RID: 114686 RVA: 0x004112C5 File Offset: 0x0040F4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601BFFF RID: 114687 RVA: 0x004112CC File Offset: 0x0040F4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest()
		{
		}

		// Token: 0x0601C000 RID: 114688 RVA: 0x004112DF File Offset: 0x0040F4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest(TrapDefenseGetRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C001 RID: 114689 RVA: 0x00411309 File Offset: 0x0040F509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetRewardRequest Clone()
		{
			return new TrapDefenseGetRewardRequest(this);
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x0601C002 RID: 114690 RVA: 0x00411311 File Offset: 0x0040F511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601C003 RID: 114691 RVA: 0x00411319 File Offset: 0x0040F519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetRewardRequest);
		}

		// Token: 0x0601C004 RID: 114692 RVA: 0x00411327 File Offset: 0x0040F527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C005 RID: 114693 RVA: 0x0041135C File Offset: 0x0040F55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C006 RID: 114694 RVA: 0x00411390 File Offset: 0x0040F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C007 RID: 114695 RVA: 0x0041139D File Offset: 0x0040F59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C008 RID: 114696 RVA: 0x004113A6 File Offset: 0x0040F5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrapDefenseGetRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C009 RID: 114697 RVA: 0x004113D0 File Offset: 0x0040F5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrapDefenseGetRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C00A RID: 114698 RVA: 0x00411409 File Offset: 0x0040F609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C00B RID: 114699 RVA: 0x00411437 File Offset: 0x0040F637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C00C RID: 114700 RVA: 0x00411440 File Offset: 0x0040F640
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrapDefenseGetRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A23C RID: 41532
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A23D RID: 41533
		public const int IdsFieldNumber = 14;

		// Token: 0x0400A23E RID: 41534
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A23F RID: 41535
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
