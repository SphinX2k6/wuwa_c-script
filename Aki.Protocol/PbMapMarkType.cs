using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF9 RID: 3065
	public sealed class PbMapMarkType : IMessage<PbMapMarkType>, IMessage, IEquatable<PbMapMarkType>, IDeepCloneable<PbMapMarkType>, IBufferMessage
	{
		// Token: 0x06010AAE RID: 68270 RVA: 0x00271813 File Offset: 0x0026FA13
		[NullableContext(1)]
		public static PbMapMarkType Create()
		{
			return new PbMapMarkType();
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x06010AAF RID: 68271 RVA: 0x0027181A File Offset: 0x0026FA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x06010AB0 RID: 68272 RVA: 0x0027181D File Offset: 0x0026FA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMapMarkType.Descriptor;
			}
		}

		// Token: 0x06010AB1 RID: 68273 RVA: 0x00271824 File Offset: 0x0026FA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType()
		{
		}

		// Token: 0x06010AB2 RID: 68274 RVA: 0x0027182C File Offset: 0x0026FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType(PbMapMarkType other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AB3 RID: 68275 RVA: 0x00271845 File Offset: 0x0026FA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMapMarkType Clone()
		{
			return new PbMapMarkType(this);
		}

		// Token: 0x06010AB4 RID: 68276 RVA: 0x0027184D File Offset: 0x0026FA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMapMarkType);
		}

		// Token: 0x06010AB5 RID: 68277 RVA: 0x0027185B File Offset: 0x0026FA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMapMarkType other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010AB6 RID: 68278 RVA: 0x0027187C File Offset: 0x0026FA7C
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

		// Token: 0x06010AB7 RID: 68279 RVA: 0x002718A2 File Offset: 0x0026FAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AB8 RID: 68280 RVA: 0x002718AF File Offset: 0x0026FAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AB9 RID: 68281 RVA: 0x002718B8 File Offset: 0x0026FAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010ABA RID: 68282 RVA: 0x002718D0 File Offset: 0x0026FAD0
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

		// Token: 0x06010ABB RID: 68283 RVA: 0x002718F6 File Offset: 0x0026FAF6
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

		// Token: 0x06010ABC RID: 68284 RVA: 0x00271913 File Offset: 0x0026FB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010ABD RID: 68285 RVA: 0x0027191C File Offset: 0x0026FB1C
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

		// Token: 0x04006A6C RID: 27244
		private UnknownFieldSet _unknownFields;

		// Token: 0x02001916 RID: 6422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x02001AB0 RID: 6832
			public enum ENUMS
			{
				// Token: 0x0400D18A RID: 53642
				[OriginalName("None")]
				None,
				// Token: 0x0400D18B RID: 53643
				[OriginalName("Custom")]
				Custom,
				// Token: 0x0400D18C RID: 53644
				[OriginalName("Quest")]
				Quest,
				// Token: 0x0400D18D RID: 53645
				[OriginalName("Building")]
				Building,
				// Token: 0x0400D18E RID: 53646
				[OriginalName("TemporaryTeleport")]
				TemporaryTeleport,
				// Token: 0x0400D18F RID: 53647
				[OriginalName("SoundBox")]
				SoundBox,
				// Token: 0x0400D190 RID: 53648
				[OriginalName("TreasureBox")]
				TreasureBox,
				// Token: 0x0400D191 RID: 53649
				[OriginalName("TreasureBoxPoint")]
				TreasureBoxPoint,
				// Token: 0x0400D192 RID: 53650
				[OriginalName("CalmingWindBell")]
				CalmingWindBell,
				// Token: 0x0400D193 RID: 53651
				[OriginalName("EnrichmentArea")]
				EnrichmentArea,
				// Token: 0x0400D194 RID: 53652
				[OriginalName("EnrichmentAreaChild")]
				EnrichmentAreaChild,
				// Token: 0x0400D195 RID: 53653
				[OriginalName("HookLockSoundBox")]
				HookLockSoundBox,
				// Token: 0x0400D196 RID: 53654
				[OriginalName("HonamiStory")]
				HonamiStory,
				// Token: 0x0400D197 RID: 53655
				[OriginalName("HonamiStoryChild")]
				HonamiStoryChild,
				// Token: 0x0400D198 RID: 53656
				[OriginalName("LahairoHookLock")]
				LahairoHookLock,
				// Token: 0x0400D199 RID: 53657
				[OriginalName("LiangYuanSoundBox")]
				LiangYuanSoundBox
			}
		}
	}
}
