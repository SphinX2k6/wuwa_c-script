using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C09 RID: 3081
	public sealed class PbMapMarkType : IMessage<PbMapMarkType>, IMessage, IEquatable<PbMapMarkType>, IDeepCloneable<PbMapMarkType>, IBufferMessage
	{
		// Token: 0x06010BAE RID: 68526 RVA: 0x0027357B File Offset: 0x0027177B
		[NullableContext(1)]
		public static PbMapMarkType Create()
		{
			return new PbMapMarkType();
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x06010BAF RID: 68527 RVA: 0x00273582 File Offset: 0x00271782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x06010BB0 RID: 68528 RVA: 0x00273585 File Offset: 0x00271785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMapMarkType.Descriptor;
			}
		}

		// Token: 0x06010BB1 RID: 68529 RVA: 0x0027358C File Offset: 0x0027178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType()
		{
		}

		// Token: 0x06010BB2 RID: 68530 RVA: 0x00273594 File Offset: 0x00271794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType(PbMapMarkType other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BB3 RID: 68531 RVA: 0x002735AD File Offset: 0x002717AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType Clone()
		{
			return new PbMapMarkType(this);
		}

		// Token: 0x06010BB4 RID: 68532 RVA: 0x002735B5 File Offset: 0x002717B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMapMarkType);
		}

		// Token: 0x06010BB5 RID: 68533 RVA: 0x002735C3 File Offset: 0x002717C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMapMarkType other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010BB6 RID: 68534 RVA: 0x002735E4 File Offset: 0x002717E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010BB7 RID: 68535 RVA: 0x0027360A File Offset: 0x0027180A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BB8 RID: 68536 RVA: 0x00273617 File Offset: 0x00271817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BB9 RID: 68537 RVA: 0x00273620 File Offset: 0x00271820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BBA RID: 68538 RVA: 0x00273638 File Offset: 0x00271838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010BBB RID: 68539 RVA: 0x0027365E File Offset: 0x0027185E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbMapMarkType other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010BBC RID: 68540 RVA: 0x0027367B File Offset: 0x0027187B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BBD RID: 68541 RVA: 0x00273684 File Offset: 0x00271884
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006A58 RID: 27224
		private UnknownFieldSet _unknownFields;

		// Token: 0x0200189E RID: 6302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x02001A0E RID: 6670
			public enum ENUMS
			{
				// Token: 0x0400CC20 RID: 52256
				[OriginalName("None")]
				None,
				// Token: 0x0400CC21 RID: 52257
				[OriginalName("Custom")]
				Custom,
				// Token: 0x0400CC22 RID: 52258
				[OriginalName("Quest")]
				Quest,
				// Token: 0x0400CC23 RID: 52259
				[OriginalName("Building")]
				Building,
				// Token: 0x0400CC24 RID: 52260
				[OriginalName("TemporaryTeleport")]
				TemporaryTeleport,
				// Token: 0x0400CC25 RID: 52261
				[OriginalName("SoundBox")]
				SoundBox,
				// Token: 0x0400CC26 RID: 52262
				[OriginalName("TreasureBox")]
				TreasureBox,
				// Token: 0x0400CC27 RID: 52263
				[OriginalName("TreasureBoxPoint")]
				TreasureBoxPoint,
				// Token: 0x0400CC28 RID: 52264
				[OriginalName("CalmingWindBell")]
				CalmingWindBell,
				// Token: 0x0400CC29 RID: 52265
				[OriginalName("EnrichmentArea")]
				EnrichmentArea,
				// Token: 0x0400CC2A RID: 52266
				[OriginalName("EnrichmentAreaChild")]
				EnrichmentAreaChild,
				// Token: 0x0400CC2B RID: 52267
				[OriginalName("HookLockSoundBox")]
				HookLockSoundBox,
				// Token: 0x0400CC2C RID: 52268
				[OriginalName("HonamiStory")]
				HonamiStory,
				// Token: 0x0400CC2D RID: 52269
				[OriginalName("HonamiStoryChild")]
				HonamiStoryChild,
				// Token: 0x0400CC2E RID: 52270
				[OriginalName("LahairoHookLock")]
				LahairoHookLock,
				// Token: 0x0400CC2F RID: 52271
				[OriginalName("LiangYuanSoundBox")]
				LiangYuanSoundBox
			}
		}
	}
}
